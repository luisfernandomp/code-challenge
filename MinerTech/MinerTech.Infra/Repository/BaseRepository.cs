using Microsoft.EntityFrameworkCore;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Response;
using MinerTech.Infra.Context;

namespace MinerTech.Infra.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MinerTechContext _context;

        public BaseRepository(MinerTechContext mySqlContext)
        {
            _context = mySqlContext;
        }

        public async Task Insert(TEntity obj)
        {
            await _context.Set<TEntity>().AddAsync(obj);
            await Save();
        }

        public async Task Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await Save();
        }

        public async Task Delete(int id)
        {
            _context.Set<TEntity>().Remove(await Select(id));
            await Save();
        }

        public async Task<IList<TEntity>> Select() =>
            await _context.Set<TEntity>().ToListAsync();

        public async Task<TEntity> Select(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> List()
        {
            return _context.Set<TEntity>();
        }

        public async Task<PagedResult> GetPaged(IQueryable<TEntity> query, int page, int itensPerPage)
        {
            var result = new PagedResult();
            result.CurrentPage = page;
            result.ItensPerPage = itensPerPage;
            result.RowCount = await query.CountAsync();


            var pageCount = (double)result.RowCount / itensPerPage;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (page - 1) * itensPerPage;
            result.Results = query.Skip(skip).Take(itensPerPage)
                .Cast<object>()
                .ToList();

            return result;
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
