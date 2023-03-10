namespace ChatApp.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        IQueryable<T> GetAll();
        T? GetById(int id);
        int SaveChanges();
    }
}
