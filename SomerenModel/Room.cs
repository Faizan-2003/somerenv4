namespace SomerenModel
{
    public class Room
    {
        public int roomId { get; set; }          // database id
        public int roomNumber { get; set; }      // RoomNumber, e.g. 206
        public string roomType { get; set; }       // student = false, teacher = true
        public int floor { get; set; }        // first floor or second floor
        public string buildingId { get; set; }   // building A or B
    }
}