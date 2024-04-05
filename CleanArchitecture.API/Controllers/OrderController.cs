using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost]
        public int Create([FromBody] Order order)
        {
            var user = unitOfWork.UserRepo.Get(order.UserId);

            if (user == null) unitOfWork.UserRepo.Create(order.User);

            unitOfWork.OrderRepo.Create(order);
            unitOfWork.Save();

            return order.Id;
        }

        [HttpGet]
        public Order Get(int id) => unitOfWork.OrderRepo.Get(id);
    }
}