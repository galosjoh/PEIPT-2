using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Galos_PEIPT2.Models;
using Galos_PEIPT2.Services;
using Galos_PEIPT2.ViewModels;

namespace RestReservation.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _RestaurantService;

        public RestaurantController(IRestaurantService RestaurantService)
        {
            _RestaurantService = RestaurantService;
        }

        public IActionResult Index()
        {
            RestaurantListViewModel viewModel = new()
            {
                Restaurants = _RestaurantService.GetAllRestaurants(),
            };
            return View(viewModel);
        }
    }
}