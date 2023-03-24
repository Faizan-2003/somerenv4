namespace SomerenModel
{
    public class Lecturer
    {
        public int lecturerId { get; set; }     // database id
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int telephone { get; set; }
        public int age { get; set; }
        public int roomId { get; set; }
        public bool isSupervisor { get; set; }
    }
}