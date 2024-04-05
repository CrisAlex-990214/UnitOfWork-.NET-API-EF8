using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;
        private IGenericRepo<User> userRepo;
        private IGenericRepo<Order> orderRepo;

        public UnitOfWork(Context context)
        {
            this.context = context;
        }

        public IGenericRepo<User> UserRepo { get => userRepo ??= new GenericRepo<User>(context); }
        public IGenericRepo<Order> OrderRepo { get => orderRepo ??= new GenericRepo<Order>(context); }

        public void Save() => context.SaveChanges();
    }
}
