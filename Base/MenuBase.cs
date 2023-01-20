using CoffeeShop.ViewModels;
using CoffeeShop.Models;
using CoffeeShop.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoffeeShop.Views;

namespace CoffeeShop.Base;

public partial class MenuBase : ObservableObject
{
    public ShoppingCart ShoppingCart { get; set; }

    private readonly ICafeService _cafeService;

    public ObservableCollection<ListViewProduct> Products { get; set; } = new();
   

    public MenuBase(ICafeService cafeService, ShoppingCart shoppingCart)
    { 
        _cafeService= cafeService;
        ShoppingCart= shoppingCart;
    }


    [RelayCommand]
    void decrement(ListViewProduct i)
    {
        if(i.Quantity > 0)
        {
            i.Quantity -= 1;
        }
      
    }

    [RelayCommand]
    void increment(ListViewProduct i) 
    {
        i.Quantity += 1;
    }

    [RelayCommand]
    void AddToCart(ListViewProduct i)
    {
        if (i .Quantity > 0)
        {
            ShoppingCart.AddItem(i.Item, i.quantity);
            i.quantity = 0; // reseting the value
        }
    }

    [RelayCommand]
    async Task Data()
    {
        var temp = await _cafeService.Offer();
        foreach(var t in temp)
        {
            Products.Add(new ListViewProduct(t));
        }
    }

}