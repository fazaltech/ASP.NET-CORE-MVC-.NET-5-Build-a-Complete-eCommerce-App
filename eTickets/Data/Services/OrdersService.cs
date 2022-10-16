using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly AppDbContext _context;
        public OrdersService(AppDbContext context)
        {
            _context = context;
        }
        public Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task StoreOrderAsync(List<ShoppingCartItem> item, string userId, string userEmailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
