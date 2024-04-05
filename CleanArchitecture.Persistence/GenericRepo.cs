using CleanArchitecture.Application.Interfaces;

namespace CleanArchitecture.Persistence
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly Context context;

        public GenericRepo(Context context)
        {
            this.context = context;
        }

        public T Create(T entity) => context.Add(entity).Entity;

        public T Get(int id) => context.Find<T>(id);
    }
}