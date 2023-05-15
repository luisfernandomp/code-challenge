using MinerTech.Domain.Entities.Cargueiro.Dtos;
using MinerTech.Domain.Response;

namespace MinerTech.Domain.Interfaces
{
    public interface IMinerioService
    {
        Task<ResponseApi> ObterPorId(int id);
        Task<ResponseApi> ObterPorCodigoOuCaracteristica(string codigoOuCaracteristica, int page, int itensPerPage);
        Task<ResponseApi> ObterTodos(int page, int itensPerPage);
        Task<ResponseApi> Cadastrar(MinerioDto dto);
        Task<ResponseApi> Inativar(int id);
        Task<ResponseApi> AlterarCaracteristica(int id, string caracteristica);
    }
}
