using CoffeeShop.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using CoffeeShop.Services;
using System.Collections.ObjectModel;

namespace CoffeeShop.ViewModels;

public partial class OrdersViewModel : ObservableObject
{
    private readonly IOrdersService _ordersService;
    public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
    public OrdersViewModel(IOrdersService ordersService)
    {
        _ordersService = ordersService;
        LoadOrders();
    }

   public void LoadOrders()
    {
        // Orders.Clear();
        Orders = new ObservableCollection<Order>(_ordersService.Orders());
    }
  
}

