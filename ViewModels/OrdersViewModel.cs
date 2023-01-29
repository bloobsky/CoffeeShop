using CoffeeShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using CoffeeShop.Services;
using System.Collections.ObjectModel;
using CoffeeShop.Views;

namespace CoffeeShop.ViewModels;

public partial class OrdersViewModel : ObservableObject
{
    private readonly IOrdersService _ordersService;
    public ObservableCollection<DetailedOrder> Orders { get; set; } = new ObservableCollection<DetailedOrder>();
    public OrdersViewModel(IOrdersService ordersService)
    {
        _ordersService = ordersService;
        LoadOrders();
    }

   public void LoadOrders()
    {
        foreach (var order in _ordersService.Orders())
        { 
            Orders.Add(order);   
        }
// Orders = new ObservableCollection<DetailedOrder>(_ordersService.Orders());
// OnPropertyChanged(nameof(Orders));

    }
    
    [RelayCommand]
    public void RefreshOrders()
    {
        // MainThread.BeginInvokeOnMainThread(() => { Orders.Clear(); OnPropertyChanged(nameof(Orders));  LoadOrders();  });
       Orders.Clear();
       LoadOrders();
    }
}

