using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        // creating field roomdb form class RoomDao
        private RoomDao roomdb;
        
        public RoomService()
        {
          // new RoomDao from RoomDao roomdb
            roomdb = new RoomDao();
        }
        public List<Room> GetRooms()
        {
            // getting room data from the database to "Rooms" with the method GellAllRooms()
            List<Room> Rooms = roomdb.GetAllRooms();
            return Rooms;
        }
            
    }
}
