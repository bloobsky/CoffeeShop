using CoffeeShop.Base;
using CoffeeShop.Models;
using CoffeeShop.Services;

namespace CoffeeShop.ViewModels;

public class MenuViewModel: MenuBase
{
    public MenuViewModel(IMenuService cafeService, ShoppingCart shoppingCart) : base(cafeService, shoppingCart)
    {

    }
}

