using Microsoft.Maui.Controls.Internals;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace CoffeeShop.Models;

public class ShoppingCart
{
    public ObservableCollection<ShoppingCartProduct> Products { get; set; } = new();
    public EventHandler<string> ProductAdded;
    public EventHandler<string> ProductRemoved;

    public void AddItem(Item i, int quantity)
    {
        // logic for not creating new object just increase the quantity, otherwise products will appear as different object 
        if (Products.Any(t => t.Item.Id == i.Id))
        {
            var cartProduct = Products.FirstOrDefault(t => t.Item.Id == i.Id);
            if (cartProduct != null) cartProduct.Quantity += quantity;
        }
        else
        {
            Products.Add(new ShoppingCartProduct(i, quantity));
        }
        ProductAdded?.Invoke(this, i.Name);
    }
    public decimal ShoppingCartAll => Products.Sum(t => t.PriceTotal);

}