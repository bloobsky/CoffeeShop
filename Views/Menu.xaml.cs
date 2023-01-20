using CoffeeShop.ViewModels;
using CoffeeShop.Helpers;
using CoffeeShop.Models;

namespace CoffeeShop.Views;


public partial class Menu : ContentPage, IDisposable
{
	private readonly MenuViewModel _menuViewModel;
	public Menu(MenuViewModel menuViewModel)
	{
		InitializeComponent();
		_menuViewModel = menuViewModel;
		BindingContext = _menuViewModel;
		_menuViewModel.ShoppingCart.ProductAdded += ShoppingCart_ProductsAdded;
	}

	private async void ShoppingCart_ProductsAdded(object sender, string name)
	{
		await ToastProduct.ShowToast(name);
	}

	public void Dispose() 
	{
		_menuViewModel.ShoppingCart.ProductAdded -= ShoppingCart_ProductsAdded;
	}
}