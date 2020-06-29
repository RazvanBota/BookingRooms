using System.ComponentModel.DataAnnotations;

namespace BookingRooms.Models
{
    public class UserModel
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
