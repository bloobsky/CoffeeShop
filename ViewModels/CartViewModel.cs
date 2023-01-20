using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CoffeeShop.Models;

namespace CoffeeShop.ViewModels;

public class CartViewModel : ObservableObject
{

    private readonly ShoppingCart _shoppingCart;

    public CartViewModel(ShoppingCart shoppingCart)
    {
        _shoppingCart= shoppingCart;
    }

    public ObservableCollection<ShoppingCartProduct> ShoppingCartProducts => _shoppingCart.Products;

    public decimal ShoppingCartAll => _shoppingCart.ShoppingCartAll;

    public void UpdateShoppingCart()
    {
        OnPropertyChanged(nameof(ShoppingCartAll));
    }

}