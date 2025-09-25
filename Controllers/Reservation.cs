using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Galos_PEIPT2.Models;
using Galos_PEIPT2.Services;
using Galos_PEIPT2.ViewModels;

namespace Galos_PEIPT2.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _ReservationService;
        private readonly IRestaurantService _RestaurantService;

        public ReservationController(IReservationService ReservationService, IRestaurantService RestaurantService)
        {
            _ReservationService = ReservationService;
            _RestaurantService = RestaurantService;
        }

        public IActionResult Index()
        {
            ReservationViewListModel viewModel = new()
            {
                Reservations = _ReservationService.GetAllReservations()
            };
            return View(viewModel);
        }
    }
}