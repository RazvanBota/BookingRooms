using BookingRooms.Models;
using BookingRooms.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BookingRooms.Service
{
    public class UserService
    {
        private readonly WriteDb _writeInDB;
        private readonly ReadDb _readFromDB;

        public UserService()
        {
            _writeInDB = new WriteDb();
            _readFromDB = new ReadDb();
        }

        public void AddUser(UserModel user)
        {
            user.Id = System.Guid.NewGuid().ToString();
            _writeInDB.CreateUser(user);
        }

        internal List<UserModel> GetAllUsers()
        {
            return _readFromDB.GetAllUsers();
        }

        internal bool DoLogin(UserModel user)
        {
            List<UserModel> users = _readFromDB.GetAllUsers();
            bool isUserValid = users.FirstOrDefault(u => u.Username.Equals(user.Username) && u.Password.Equals(user.Password)) != null;

            return isUserValid;
        }

        internal void EditUser(UserModel user)
        {
            _writeInDB.UpdateUser(user);
        }

        internal UserModel FindUserById(string id)
        {
            return _readFromDB.GetUserById(id);
        }
    }
}
