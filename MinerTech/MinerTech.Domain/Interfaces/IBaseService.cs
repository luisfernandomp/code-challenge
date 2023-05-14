using FluentValidation;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> Add(TEntity obj);
        Task Delete(int id);
        Task<IList<TEntity>> Get();
        Task<TEntity> GetById(int id);
        Task<TEntity> Update(TEntity obj);
        IQueryable<TEntity> List();
        Task<PagedResult> GetPaged(IQueryable<TEntity> query, int page, int pageSize);
    }
}
