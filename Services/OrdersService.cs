using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;
using System.Text.Json;
using CoffeeShop.Services;
using CoffeeShop.Views;
using System.Diagnostics;


namespace CoffeeShop.Services
{
    internal class OrdersService : IOrdersService
    {
        List<DetailedOrder> orders = new List<DetailedOrder>();
        public IEnumerable<DetailedOrder> Orders()
        {
            orders.Clear();
            var files = Directory.GetFiles(FileSystem.Current.AppDataDirectory, "*.txt");
            Debug.WriteLine(FileSystem.Current.AppDataDirectory);
            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);
                var ordering = JsonSerializer.Deserialize<DetailedOrder>(fileContent);
                orders.Add(ordering);
            }
            return orders;
            
        }
    }
}
