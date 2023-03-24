using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao ordersdb;

        public OrderService()
        {
            ordersdb = new OrderDao();
        }

        public static void AddData(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = ordersdb.GetAllOrders();
            return orders;
        }
    }
}
