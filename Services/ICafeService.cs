using CoffeeShop.Models;

namespace CoffeeShop.Services;

public interface ICafeService
{
    public Task<List<Item>> Offer();
}
