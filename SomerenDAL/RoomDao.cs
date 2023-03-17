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
<<<<<<< Updated upstream
            string query = "SELECT roomID, roomNumber, roomTyppe, floor, buildingId FROM [ROOM]";
=======
            // query showing what do we need to take from the database
            string query = "SELECT roomID, roomNumber, roomType, floor, buildingId FROM [ROOM]";
>>>>>>> Stashed changes
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            //creating a list room
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    // the content of the databse redirecrting to the variables from the rooms
                    roomId = (int)dr["roomId"],
<<<<<<< Updated upstream
                    roomNumber =(int) dr["roomNumber"],
=======
                    roomNumber = (int)dr["roomNumber"],
>>>>>>> Stashed changes
                    roomType = (bool)dr["roomType"],
                    floor = (int)dr["floor"],
                    buildingId = dr["buildingId"].ToString(),

                };
                //adding the items to the room
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
