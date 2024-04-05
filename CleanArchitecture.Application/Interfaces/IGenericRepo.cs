namespace CleanArchitecture.Application.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        T Create(T entity);
        T Get(int id);
    }
}
