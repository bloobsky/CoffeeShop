using CoffeeShop.Models;

namespace CoffeeShop.Services;

public class MenuService : IMenuService
{
    public async Task<List<Item>> Offer()
    {
        var menuList = new List<Item>();

        var menuItem = new Item
        {
            Id = 1,
            Type = "Hot Beverages",
            Name = "Espresso",
            Description = "Hand Brewed Espresso with Brazilian Coffee",
            Image = "espresso.png",
            Price = 2,
        };

        var menuItem2 = new Item
        {
            Id = 2,
            Type = "Food",
            Name = "Bagel with organic cheese",
            Description = "Hand crafted dough topped with organic french goat's cheese",
            Image = "bagel.png",
            Price = 10,
        };

        var menuItem3 = new Item
        {
            Id = 3,
            Type = "Hot Beverages",
            Name = "Chai Latte",
            Description = "Organic Black Tea, steamed milk infused with spices",
            Image = "chailatte.png",
            Price = 3,
        };

        var menuItem4 = new Item
        {
            Id = 4,
            Type = "Food",
            Name = "Organic Beef Burger",
            Description = "100% Irish Beef of Angus breed",
            Image = "burger.png",
            Price = 11,
        };

        var menuItem5 = new Item
        {
            Id = 5,
            Type = "Hot Beverages",
            Name = "Lemon Zesty Tea",
            Description = "Organic Indian Tea, topped with lime zest",
            Image = "tea.png",
            Price = 2.5M,
        };

        var menuItem6 = new Item
        {
            Id = 6,
            Type = "Food",
            Name = "Canadian Maple Donut",
            Description = "Hand kneaded dough topped with 100% Canadian maple syrup",
            Image = "donut.png",
            Price = 3.75M,
        };

        var menuItem7 = new Item
        {
            Id = 7,
            Type = "Cold Beverages",
            Name = "Iced Carmel Macchiato",
            Description = "Home Made Carmel topped up with coffee shot",
            Image = "macchiato.png",
            Price = 3.25M,
        };

        var menuItem8 = new Item
        {
            Id = 8,
            Type = "Food",
            Name = "Organic Chicken Wrap",
            Description = "Homemade Tortilla topped with crispy chicken & salad",
            Image = "chicken.png",
            Price = 8.25M,
        };

        var menuItem9 = new Item
        {
            Id = 9,
            Type = "Cold Beverages",
            Name = "Chocolate Shaked",
            Description = "Crushed Iced topped with Belgian Chocolate",
            Image = "shake.png",
            Price = 3.5M,
        };

        menuList.Add(menuItem);
        menuList.Add(menuItem2);
        menuList.Add(menuItem3);
        menuList.Add(menuItem4);
        menuList.Add(menuItem5);
        menuList.Add(menuItem6); 
        menuList.Add(menuItem7);
        menuList.Add(menuItem8);
        menuList.Add(menuItem9);

        return menuList;




    }
}