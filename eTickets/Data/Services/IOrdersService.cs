using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
  public  interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> item, string userId, string userEmailAddress);

        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
