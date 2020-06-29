using BookingRooms.Models;
using BookingRooms.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookingRooms.Controllers
{
    public class RoomsController : Controller
    {
        private RoomsService _roomsService;

        public RoomsController()
        {
            _roomsService = new RoomsService();
        }

        public IActionResult AddRoomView()
        {
            return View("AddRoom");
        }

        public IActionResult AddRoom(RoomModel room)
        {
            _roomsService.AddRoom(room);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditRoomView(string id)
        {
            RoomModel room = _roomsService.FindRoomById(id);

            return View("EditRoom", room);
        }

        public IActionResult EditRoom(RoomModel room)
        {
            _roomsService.EditRoom(room);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult BookRoom(string id)
        {
            RoomModel room = _roomsService.FindRoomById(id);

            return View("BookRoom", room);
        }
    }
}
