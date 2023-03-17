namespace SomerenModel
{
    public class Room
    {
        public int roomId { get; set; }          // database id
        public int roomNumber { get; set; }      // RoomNumber, e.g. 206
        public bool roomType { get; set; }       // student = false, teacher = true
<<<<<<< Updated upstream
=======
        public int capacity { get; set; }        // capacity of the room , 1 or 8
>>>>>>> Stashed changes
        public int floor { get; set; }        // first floor or second floor
        public string buildingId { get; set; }   // building A or B
    }
}