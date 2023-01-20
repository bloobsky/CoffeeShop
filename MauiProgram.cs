using Microsoft.Extensions.Logging;
using CoffeeShop.ViewModels;
using CoffeeShop.Views;
using CoffeeShop.Models;
using CoffeeShop.Services;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;


namespace CoffeeShop;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Community Toolkit Mvvm
		builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
		builder.UseMauiApp<App>().UseMauiCommunityToolkit();

		//Services
		builder.Services.AddSingleton<IMenuService, MenuService>();

		//Views
		builder.Services.AddSingleton<Cart>();
        builder.Services.AddSingleton<Menu>();
        builder.Services.AddSingleton<Orders>();

		//View Models

		builder.Services.AddSingleton<MenuViewModel>();
		builder.Services.AddSingleton<CartViewModel>();


		//ShoppingCaERT
		builder.Services.AddSingleton<ShoppingCart>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
