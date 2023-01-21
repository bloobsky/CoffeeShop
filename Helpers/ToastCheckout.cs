using CommunityToolkit.Maui.Alerts;
namespace CoffeeShop.Helpers;

public static class ToastCheckout
{
    public static async Task ShowToast()
    {
        var msg = Toast.Make($"Your order has been placed. Thank you !");
        await msg.Show();

    }
}