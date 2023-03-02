namespace PrincipiosSOLID.ISP
{
    public interface IRepository<T>
    {
        void Add(T data);
        void Update(T data);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
    }
}
