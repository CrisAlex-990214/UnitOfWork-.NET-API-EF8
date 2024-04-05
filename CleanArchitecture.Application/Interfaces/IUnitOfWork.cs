using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IGenericRepo<User> UserRepo { get; }
        public IGenericRepo<Order> OrderRepo { get; }
        void Save();
    }
}
