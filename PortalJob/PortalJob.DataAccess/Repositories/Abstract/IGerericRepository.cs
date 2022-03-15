using PortalJob.Domain;

namespace PortalJob.DataAccess.Repositories.Abstract
{
    public interface IGerericRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Func<T, bool> func);
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<int> Delete(T entity);
    }
}
