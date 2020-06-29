using BookingRooms.Models;
using BookingRooms.Repository;
using System;
using System.Collections.Generic;

namespace BookingRooms.Service
{
    public class RoomsService
    {
        private readonly WriteDb _writeInDB;
        private readonly ReadDb _readFromDB;

        public RoomsService()
        {
            _writeInDB = new WriteDb();
            _readFromDB = new ReadDb();
        }

        public void AddRoom(RoomModel room)
        {
            room.Id = Guid.NewGuid().ToString();
            room.IsAvailable = true;
            room.BookedUntil = DateTime.UtcNow.AddHours(-5);

            _writeInDB.CreateRoom(room);
        }

        public List<RoomModel> GetAllRooms()
        {
            return _readFromDB.GetAllRooms();
        }

        public RoomModel FindRoomById(string id)
        {
            return _readFromDB.GetRoomById(id);
        } 
        
        public void EditRoom(RoomModel room)
        {
            _writeInDB.UpdateRoom(room);
        }
    }
}
