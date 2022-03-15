namespace PortalJob.DataAccess.Repositories.Concret
{
    using Microsoft.EntityFrameworkCore;
    using PortalJob.DataAccess.Configurations;
    using PortalJob.DataAccess.Repositories.Abstract;
    using PortalJob.Domain;

    public class GenericRepository<T> : IGerericRepository<T> where T : EntityBase
    {
        private readonly DbSet<T> _entity;
        private readonly PortalJobsContext _context;

        public GenericRepository(PortalJobsContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public virtual Task<IEnumerable<T>> GetAll(Func<T, bool> func)
        {
            return Task.FromResult(_entity.Where(func));
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _entity.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<T> Add(T entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task<T> Update(T entity)
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<int> Delete(T entity)
        {
            _entity.Remove(entity);
            return await _context.SaveChangesAsync();
        }
    }
}
