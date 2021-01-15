using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TropicalServerApp.Models;

namespace TropicalServerApp.ViewModel
{
    public class OrderViewModel
    {
        // Order
        public Order order { get; set; }
        // List of Orders
        public List<Order> orders { get; set; }
    }
}