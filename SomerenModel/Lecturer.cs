namespace SomerenModel
{
    public class Lecturer
    {
        public int lecturerId { get; set; }     // Database Id of the lecturer
        public string firstName { get; set; }   // First Name of the lecturer
        public string lastName { get; set; }    // Last Name of the lecturer
        public int telephone { get; set; }  // Telephone Number of the lecturer
        public int age { get; set; }    // Age of the lecturer
        public int roomId { get; set; }     // Database Id of the room
        public bool isSupervisor { get; set; }  // Is the lecturer a supervisor or not
    }
}