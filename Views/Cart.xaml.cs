using CoffeeShop.ViewModels;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

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
        string DownloadsPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, Android.OS.Environment.DirectoryDownloads);
        string filePath = Path.Combine(DownloadsPath, "json.txt");
        JsonSerializer serializer = new JsonSerializer();
		serializer.Converters.Add(new JavaScriptDateTimeConverter());
        using (StreamWriter sw = new StreamWriter(filePath))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            serializer.Serialize(writer, _cartViewModel);
            // {"ExpiryDate":new Date(1230375600000),"Price":0}
        }



    }
}

