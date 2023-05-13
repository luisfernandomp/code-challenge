using MinerTech.Domain.Entities;
using MinerTech.Domain.Interfaces;
using MinerTech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTech.Infra.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MinerTechContext _context;
        public BaseRepository(MinerTechContext context) 
        {
            _context = context;
        }

        public void Delete(int id)
        {
            _context.Set<TEntity>().Remove(Select(id));
            _context.SaveChanges();
        }

        public IList<TEntity> FindAll(Func<TEntity> func)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public TEntity Select(int id)
        {
            return _context.Set<TEntity>().SingleOrDefault(x => x.Id == id);
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
            _context.SaveChanges();
        }
    }
}
