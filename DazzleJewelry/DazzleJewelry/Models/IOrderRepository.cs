using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DazzleJewelry.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        IEnumerable<Order> getAll();

        void DeleteOrder(int orderId);
    }
}
