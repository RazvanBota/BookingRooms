using BookingRooms.Models;

namespace BookingRooms.Repository
{
    public class WriteDb
    {
        public void CreateRoom(RoomModel room)
        {
            using (BookingContextModel db = new BookingContextModel())
            {
                db.Rooms.Add(room); 
                db.SaveChanges();
            }
        }

        public void UpdateRoom(RoomModel room)
        {
            using (BookingContextModel db = new BookingContextModel())
            {
                var result = db.Rooms.Find(room.Id);

                result.BookedUntil = room.BookedUntil;
                result.IsAvailable = room.IsAvailable;
                result.Name = room.Name; 

                db.SaveChanges();
            }
        }

        public void CreateUser(UserModel user)
        {
            using (BookingContextModel db = new BookingContextModel())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        internal void UpdateUser(UserModel user)
        {
            using (BookingContextModel db = new BookingContextModel())
            {
                var result = db.Users.Find(user.Id);

                result.Username = user.Username;
                result.Password = user.Password;
                result.IsAdmin = user.IsAdmin;

                db.SaveChanges();
            }
        }
    }
}
