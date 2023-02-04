using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json.Serialization;

namespace CoffeeShop.Models;

public partial class ShoppingCartProduct : ObservableObject
{
	[ObservableProperty]
	private Item _item;
	[ObservableProperty]
	private int _quantity;

	[JsonIgnore]

	public decimal PriceTotal => _item.Price * _quantity; // suming total price

	public ShoppingCartProduct(Item i, int quantity)
	{
		_item = i; 
		_quantity = quantity;
	}
	
	public ShoppingCartProduct() { }


}