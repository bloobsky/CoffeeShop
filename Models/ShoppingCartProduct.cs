using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Models;

public partial class ShoppingCartProduct : ObservableObject 
{
	[ObservableProperty]
	private Item _item;
	[ObservableProperty]
	private int _quantity;

	public decimal PriceTotal => _item.Price * _quantity; // suming total price

	public ShoppingCartProduct(Item i, int quantity)
	{
		_item = i; 
		_quantity = quantity;
	}															
}