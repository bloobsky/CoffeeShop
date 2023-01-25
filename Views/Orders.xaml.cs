using CoffeeShop.ViewModels;

namespace CoffeeShop.Views;

public partial class Orders : ContentPage
{
	private readonly OrdersViewModel _ordersViewModel;
	public Orders(OrdersViewModel ordersViewModel)
	{
		InitializeComponent();
		_ordersViewModel = ordersViewModel;
		BindingContext= _ordersViewModel;
	}
}