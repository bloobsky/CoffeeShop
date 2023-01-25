using CoffeeShop.ViewModels;
//using System.Text.Json;
using System.Text.Json;
using System.Collections.Generic;
using CoffeeShop.Helpers;
using CoffeeShop.Models;


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

	async void SaveToFile(object sender, EventArgs e)
	{
        string customerName = await DisplayPromptAsync("Name", "Enter your name");
        string phoneNumber = await DisplayPromptAsync("Phone Number", "Enter your phone number");
        // creating unique order based by date
        DateTime now = DateTime.Now;
        var fileName = "Order" + now.ToString("yyyyMMddHHmmss") + ".txt";

        //android settings
       // string DownloadsPath = Path.Combine(); //saving to App folder
        string filePath = Path.Combine(FileSystem.Current.AppDataDirectory, fileName);

        DetailedOrder detailOrder = new DetailedOrder(customerName, phoneNumber, _cartViewModel.ShoppingCartProducts);

        // JsonSerializer serializer = new JsonSerializer();

        await using var stream = File.OpenWrite(filePath);
        await using var sw = new StreamWriter(stream);
        
       var serialized = JsonSerializer.Serialize(detailOrder);
            await sw.WriteAsync(serialized);

        
        await ToastCheckout.ShowToast(); //showing toast

    }

    public class DetailedOrder
    {
        public string CustomerName { get; set; }

        public DetailedOrder(string customerName, string phoneNumber, IEnumerable<ShoppingCartProduct> newOrder)
        {
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            NewOrder = newOrder;
        }

        public string PhoneNumber { get; set; }
        public IEnumerable<ShoppingCartProduct> NewOrder { get; set; }

    }
}

