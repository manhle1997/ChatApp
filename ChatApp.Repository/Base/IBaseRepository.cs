namespace ChatApp.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T t);
        Task<int> Update(int id, T t);
        void Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> SaveChanges();
    }
}
