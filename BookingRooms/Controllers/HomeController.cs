using BookingRooms.Models;
using BookingRooms.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace BookingRooms.Controllers
{
    public class HomeController : Controller
    {
        private RoomsService _roomsService;

        public HomeController()
        {
            _roomsService = new RoomsService();
        }

        public IActionResult Index()
        {
            List<RoomModel> rooms = _roomsService.GetAllRooms();
            return View(rooms);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
