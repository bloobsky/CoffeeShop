using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.Views;

namespace CoffeeShop.Services
{
    public interface IOrdersService
    {
        public IEnumerable<DetailedOrder> Orders();
    }
}
