namespace Hurtownia.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);

        void Add(T element);

        void Delete(T element);

        void SaveChanges();
    }
}
