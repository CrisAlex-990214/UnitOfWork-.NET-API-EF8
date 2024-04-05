﻿namespace CleanArchitecture.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
