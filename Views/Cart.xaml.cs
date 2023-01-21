using CoffeeShop.ViewModels;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using CoffeeShop.Helpers;

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
        // creating unique order based by date
        DateTime now = DateTime.Now;
        var fileName = "Order" + now.ToString("yyyyMMddHHmmss") + ".txt";

        //android settings
        string DownloadsPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads); //saving to Downloads folder
        string filePath = Path.Combine(DownloadsPath, fileName);
        JsonSerializer serializer = new JsonSerializer();
		serializer.Converters.Add(new JavaScriptDateTimeConverter());
        using (StreamWriter sw = new StreamWriter(filePath))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            serializer.Serialize(writer, _cartViewModel);
        }
        await ToastCheckout.ShowToast();


    }
}

