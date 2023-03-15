using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Collections;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        public void ShowRoomPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();

            pnlRooms.Show();
            try
            {
                List<Room> rooms = GetRooms();
                DisplayRoom(rooms);
            }

            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.StudentNumber.ToString());
                li.Tag = student;

                li.SubItems.Add(student.FirstName.ToString());
                li.SubItems.Add(student.LastName.ToString());
                li.SubItems.Add(student.telephone.ToString());
                li.SubItems.Add(student.Class.ToString());
                li.SubItems.Add(student.RoomID.ToString());
                listViewStudents.Items.Add(li);
            }
        }
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;


        }
        private void DisplayRoom(List<Room> rooms)
        {
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.roomNumber.ToString());

                li.Tag = room;

                if (room.roomType == true)
                {
                    li.SubItems.Add("Single");
                }
                else
                {
                    li.SubItems.Add("Dormitory");
                }

                li.SubItems.Add(room.floor.ToString());
                li.SubItems.Add(room.buildingId.ToString());

                listViewRooms.Items.Add(li);
            }
        }

        public void ShowLecturerPanel()
        {
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();

            pnlLecturers.Show();
            try
            {
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }

            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }
        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            listViewLecturers.Items.Clear();

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem li = new ListViewItem(lecturer.firstName.ToString());
                li.Tag = lecturer;

                li.SubItems.Add(lecturer.lastName.ToString());
                li.SubItems.Add(lecturer.telephone.ToString());
                li.SubItems.Add(lecturer.age.ToString());
                li.SubItems.Add(lecturer.roomId.ToString());
                listViewLecturers.Items.Add(li);
            }
        }



        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }

        private void dashboardToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlRooms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewLecturers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listViewLecturers.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
    }
}