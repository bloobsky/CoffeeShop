using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShop.Models;
public class Order
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    /*
    public void All_Orders()
    {
        var dir = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
        DirectoryInfo d = new DirectoryInfo(dir);
        foreach (var f in d.GetFiles("*.txt") {

            
            var order = JsonSerializer.Deserialize<Order>(f);
            var orderInfo = File.ReadAllText(f);

        }

    } */
}
    
    
