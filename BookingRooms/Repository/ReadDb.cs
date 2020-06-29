using BookingRooms.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookingRooms.Repository
{
    public class ReadDb
    {
        public List<RoomModel> GetAllRooms()
        {
            using (var db = new BookingContextModel())
            {
                var rooms = from r in db.Rooms orderby r.Name select r;
                return rooms.ToList();
            }
        }

        public RoomModel GetRoomById(string id)
        {
            using(var db = new BookingContextModel())
            {
                var room = db.Rooms.Find(id);
                return room;
            }
        }

        internal List<UserModel> GetAllUsers()
        {
            using(var db = new BookingContextModel())
            {
                var users = from u in db.Users select u;
                return users.ToList();
            }
        }

        internal UserModel GetUserById(string id)
        {
            using (var db = new BookingContextModel())
            {
                var user = db.Users.Find(id);
                return user;
            }
        }
    }
}
