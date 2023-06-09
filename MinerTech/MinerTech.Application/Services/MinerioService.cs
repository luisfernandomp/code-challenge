using AutoMapper;
using MinerTech.Domain;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Entities.Minerios;
using MinerTech.Domain.Entities.Minerios.Dtos;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Response;

namespace MinerTech.Application.Services
{
    public class MinerioService : BaseService<Minerio>, IMinerioService
    {
        public MinerioService(IBaseRepository<Minerio> baseRepository,
            NotificationContext notificationContext,
            IMapper mapper) :
            base(baseRepository, notificationContext, mapper)
        { }

        public async Task<ResponseApi> AlterarCaracteristica(int id, string caracteristica)
        {
            var minerio = await GetById(id);

            if (minerio == null)
            {
                AddNotificationIfNull(); 
                return new ResponseApi();
            }

            minerio.AlterarCaracteristica(caracteristica);

            return new ResponseApi(true, "Caracteristica alterada com sucesso!");
        }

        public async Task<ResponseApi> Cadastrar(MinerioDto dto)
        {
            var minerio = new Minerio(dto.Codigo, dto.Caracteristica);

            if (minerio.Invalid)
            {
                _notificationContext.AddNotifications(minerio.ValidationResult);
                return new ResponseApi();
            }

            await Add(minerio);
            return new ResponseApi(true, "Cadastrado com sucesso!");
        }

        public async Task<ResponseApi> Inativar(int id)
        {
            var minerio = await GetById(id);

            if (minerio == null)
            {
                AddNotificationIfNull();
                return new ResponseApi();
            }

            minerio.Inativar();

            return new ResponseApi(true, "Inativo com sucesso!");
        }

        public async Task<ResponseApi> ObterPorId(int id)
        {
            var minerio = await GetById(id);

            if (minerio == null)
            {
                AddNotificationIfNull();
                return new ResponseApi();
            }

            var dto = _mapper.Map<MinerioResponseDto>(minerio);

            return new ResponseApi(true, "", dto);
        }

        public async Task<ResponseApi> ObterPorCodigoOuCaracteristica(string codigoOuCaracteristica, int page, int itensPerPage)
        {
            var result = await GetPaged(List().Where(c => 
                c.Codigo.Contains(codigoOuCaracteristica) ||
                c.Caracteristica.Contains(codigoOuCaracteristica)
            ), page, itensPerPage);

            var response = result.Results.Select(_mapper.Map<MinerioResponseDto>).ToList();

            result.ToDto(response
                        .Cast<object>()
                        .ToList());

            return new ResponseApi(true, "", result);
        }

        public async Task<ResponseApi> ObterTodos(int page, int itensPerPage)
        {
            var result = await GetPaged(List(), page, itensPerPage);

            var response = result.Results.Select(_mapper.Map<MinerioResponseDto>).ToList();

            result.ToDto(response
                        .Cast<object>()
                        .ToList());

            return new ResponseApi(true, "", result);
        }

        public void AddNotificationIfNull()
        {
            _notificationContext.AddNotification("Minério", "Não foi possível encontrar nenhum minério com o Id informado");
        }
    }
}
