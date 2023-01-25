using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Services
{
    public interface IOrdersService
    {
        public IEnumerable<Order> Orders();
    }
}
