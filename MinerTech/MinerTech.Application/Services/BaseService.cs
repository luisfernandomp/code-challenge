using AutoMapper;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Interfaces;
using MinerTech.Domain.Response;

namespace MinerTech.Application.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        protected readonly NotificationContext _notificationContext;
        protected readonly IMapper _mapper;

        public BaseService(
            IBaseRepository<TEntity> baseRepository, 
            NotificationContext notificationContext,
            IMapper mapper)
        {
            _baseRepository = baseRepository;
            _notificationContext = notificationContext;
            _mapper = mapper;
        }

        public async Task<TEntity> Add(TEntity obj)
        {
            await _baseRepository.Insert(obj);
            return obj;
        }

        public async Task Delete(int id) => await _baseRepository.Delete(id);

        public async Task<IList<TEntity>> Get() => await _baseRepository.Select();

        public async Task<TEntity> GetById(int id) => await _baseRepository.Select(id);

        public async Task<TEntity> Update(TEntity obj)
        {
            await _baseRepository.Update(obj);
            return obj;
        }

        public IQueryable<TEntity> List()
        {
           return _baseRepository.List();
        }

        public async Task<PagedResult> GetPaged(IQueryable<TEntity> query, int page, int pageSize)
        {
            return await _baseRepository.GetPaged(query, page, pageSize);
        }

    }
}
