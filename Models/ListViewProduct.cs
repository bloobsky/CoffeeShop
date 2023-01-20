using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShop.Models;

public partial class ListViewProduct : ObservableObject
{
    public Item Item { get; set; }

    [ObservableProperty]
    public int quantity;

    public ListViewProduct(Item item)
    {
        Item = item;
    }
}