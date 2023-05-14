using MinerTech.Domain.Entities;
using MinerTech.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task Insert(TEntity obj);
        Task Update(TEntity obj);
        Task Delete(int id);
        Task<IList<TEntity>> Select();
        Task<TEntity> Select(int id);
        IQueryable<TEntity> List();
        Task<PagedResult> GetPaged(IQueryable<TEntity> query, int page, int pageSize);
    }
}
