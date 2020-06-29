using System;
using System.ComponentModel.DataAnnotations;

namespace BookingRooms.Models
{
    public class RoomModel
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime BookedUntil { get; set; }
    }
}
