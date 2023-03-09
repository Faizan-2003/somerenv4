using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

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
