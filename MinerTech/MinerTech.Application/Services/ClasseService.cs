﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MinerTech.Domain;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Entities.Classes;
using MinerTech.Domain.Entities.Classes.Dtos;
using MinerTech.Domain.Entities.Minerios;
using MinerTech.Domain.Entities.Usuario.Dto;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MinerTech.Application.Services
{
    public class ClasseService : BaseService<Classe>, IClasseService
    {
        private readonly IBaseRepository<Minerio> _minerioRepository;
        public ClasseService(IBaseRepository<Classe> baseRepository,
            IBaseRepository<Minerio> minerioRepository,
            NotificationContext notificationContext,
            IMapper mapper) :
            base(baseRepository, notificationContext, mapper)
        { }

        public async Task<ResponseApi> AlterarDescricao(int id, string descricao)
        {
            var classe = await GetById(id);

            if (classe == null)
            {
                AddNotificationIfNull(); 
                return new ResponseApi();
            }

            classe.AlterarDescricao(descricao);

            return new ResponseApi(true, "Descrição alterada com sucesso!");
        }

        public async Task<ResponseApi> Cadastrar(ClasseDto dto)
        {
            var classe = new Classe(dto.Descricao);
            var minerios = await ObterMinerios(dto.MineriosCompativeis);

            //classe.AssociarMineriosCompativeis(minerios);

            if (classe.Invalid)
            {
                _notificationContext.AddNotifications(classe.ValidationResult);
                return new ResponseApi();
            }

            await Add(classe);
            return new ResponseApi(true, "Cadastrado com sucesso!");
        }

        public async Task<List<Minerio>> ObterMinerios(int[] ids)
        {
            return await _minerioRepository
                .List()
                .Where(x => ids.Any(y => y == x.Id))
                .ToListAsync();
        }

        public async Task<ResponseApi> Inativar(int id)
        {
            var classe = await GetById(id);

            if (classe == null)
            {
                AddNotificationIfNull();
                return new ResponseApi();
            }

            classe.Inativar() ;

            return new ResponseApi(true, "Inativo com sucesso!");
        }

        public async Task<ResponseApi> ObterPorId(int id)
        {
            var classe = await GetById(id);

            if (classe == null)
            {
                AddNotificationIfNull();
                return new ResponseApi();
            }

            var dto = _mapper.Map<ClasseResponseDto>(classe);

            return new ResponseApi(true, "", dto);
        }

        public async Task<ResponseApi> ObterPorNome(string nome, int page, int itensPerPage)
        {
            var result = await GetPaged(List().Where(c => c.Descricao.Contains(nome)), page, itensPerPage);

            var response = result.Results.Select(_mapper.Map<ClasseResponseDto>).ToList();

            result.ToDto(response
                        .Cast<object>()
                        .ToList());

            return new ResponseApi(true, "", result);
        }

        public async Task<ResponseApi> ObterTodos(int page, int itensPerPage)
        {
            var result = await GetPaged(List(), page, itensPerPage);

            var response = result.Results.Select(_mapper.Map<ClasseResponseDto>).ToList();

            result.ToDto(response
                        .Cast<object>()
                        .ToList());

            return new ResponseApi(true, "", result);
        }

        public void AddNotificationIfNull()
        {
            _notificationContext.AddNotification("Classe", "Não foi possível encontrar nenhuma classe com o Id informado");
        }
    }
}
