using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomdb;
        
        public RoomService()
        {
            roomdb = new RoomDao();
        }
        public List<Room> GetRooms()
        {
            List<Room> Rooms = roomdb.GetAllRooms();
            return Rooms;
        }
            
    }
}
