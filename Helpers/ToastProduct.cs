using CommunityToolkit.Maui.Alerts;
namespace CoffeeShop.Helpers;

public static class ToastProduct
{
      public static async Task ShowToast(string name)
    {
        var msg = Toast.Make($"{name} landed in your basket !");
        await msg.Show();

    }
}