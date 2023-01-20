using CoffeeShop.ViewModels;

namespace CoffeeShop.Views;

public partial class Cart : ContentPage
{

	private CartViewModel _cartViewModel;
	public Cart(CartViewModel cartViewModel)
	{
		InitializeComponent();
		_cartViewModel = cartViewModel;
		BindingContext= _cartViewModel;
	}

    protected override void OnAppearing()
    {
		_cartViewModel.UpdateShoppingCart();
        base.OnAppearing();
    }
}