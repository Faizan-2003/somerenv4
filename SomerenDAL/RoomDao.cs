using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT roomID, roomNumber, roomType, floor, buildingId FROM [ROOM]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
             Room room = new Room()
                {
                    roomId = (int)dr["roomId"],
                    roomNumber =(int) dr["roomNumber"],
                    roomType = (bool)dr["roomType"],
                    floor = (int)dr["floor"],
                    buildingId = dr["buildingId"].ToString(),

                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
