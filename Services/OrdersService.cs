using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;
using System.Text.Json;
using CoffeeShop.Services;
using CoffeeShop.Views;

namespace CoffeeShop.Services
{
    internal class OrdersService : IOrdersService
    {
        List<Order> orders = new List<Order>();
        public IEnumerable<Order> Orders()
        {
            var files = Directory.GetFiles(FileSystem.Current.AppDataDirectory, ".txt");
            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);
                var ordering = JsonSerializer.Deserialize<Order>(fileContent);
                orders.Add(ordering);
            }
            return orders;
            
        }
    }
}
