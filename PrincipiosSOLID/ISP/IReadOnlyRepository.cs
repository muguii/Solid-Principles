namespace PrincipiosSOLID.ISP
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
    }
}
