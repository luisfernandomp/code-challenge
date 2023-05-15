﻿using MinerTech.Domain.Entities.Cargueiro.Dtos;
using MinerTech.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Interfaces
{
    public interface IClasseService
    {
        Task<ResponseApi> ObterPorId(int id);
        Task<ResponseApi> ObterPorNome(string nome, int page, int itensPerPage);
        Task<ResponseApi> ObterTodos(int page, int itensPerPage);
        Task<ResponseApi> Cadastrar(ClasseDto dto);
        Task<ResponseApi> Inativar(int id);
        Task<ResponseApi> AlterarDescricao(int id, string descricao);
    }
}
