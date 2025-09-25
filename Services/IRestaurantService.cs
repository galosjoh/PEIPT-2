using Galos_PEIPT2.Models;
using System.Collections.Generic;

namespace Galos_PEIPT2.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant? GetRestaurantById(string id);
        void AddRestaurant(Restaurant newRestaurant);
        void EditRestaurant(Restaurant updatedRestaurant);
        void DeleteRestaurant(string id);
    }
}