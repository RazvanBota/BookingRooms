using System.Data.Entity;

namespace BookingRooms.Models
{
    public class BookingContextModel : DbContext
    {
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
