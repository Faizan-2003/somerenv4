using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;
using System.Drawing;

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
            pnlDrinks.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlDrinks.Hide();

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
            // hide the rest of the panels
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlDrinks.Hide();

            // show the room panel
            pnlRooms.Show();
            try
            {
                // getting the rooms form the GetRooms method and sending it to the list and then displaying the rooms.
                List<Room> rooms = GetRooms();
                DisplayRoom(rooms);
            }

            catch (Exception e)
            {
                // show error message box if there is an error
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
            // creating variables "roomService" from class "RoomService"
            RoomService roomService = new RoomService();
            // getting room from the method GetRooms in roomService and adding them to the list room and returning them
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        private void DisplayRoom(List<Room> rooms)
        {
            // clearing the list before displaying
            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {

                ListViewItem li = new ListViewItem(room.roomId.ToString());
                li.Tag = room;   // link student object to listview item
                //li.SubItems.Add(room.Number.ToString());

                // adding roomNumber to listview
                li = new ListViewItem(room.roomNumber.ToString());

                li.Tag = room;

                // adding either the room is Single or Dormitory 
                if (room.roomType == true)
                {
                    li.SubItems.Add("Single (Lecturer)");
                    // ...
                }
                else
                {
                    li.SubItems.Add("Dormitory (Students)");
                    // ....
                }
                // adding the capacity of the room depending on the room type 1 = Single and 8 = Dormitory
                if (room.roomType == true)
                {
                    li.SubItems.Add("1");
                }
                else
                {
                    li.SubItems.Add("8");
                }
                // adding the floor number and building ID
                li.SubItems.Add(room.floor.ToString());
                li.SubItems.Add(room.buildingId.ToString());

                // adding all the item to the list view

                listViewRooms.Items.Add(li);
            }
        }

        public void ShowLecturerPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();

            // show lecturer panel

            pnlLecturers.Show();

            try
            {
                // getting the lecturers form the GetLecturers method and sending it to the list and then displaying
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }

            catch (Exception e)
            {
                // show error message box if there is an error
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
            // clearing the list before displaying
            listViewLecturers.Items.Clear();

            foreach (Lecturer lecturer in lecturers)
            {
                // adding firstName to listview
                ListViewItem li = new ListViewItem(lecturer.firstName.ToString());
                li.Tag = lecturer;

                // adding data to the listview 
                li.SubItems.Add(lecturer.lastName.ToString());
                li.SubItems.Add(lecturer.telephone.ToString());
                li.SubItems.Add(lecturer.age.ToString());
                li.SubItems.Add(lecturer.roomId.ToString());
                if (lecturer.isSupervisor == false)
                    li.SubItems.Add("No");
                else
                    li.SubItems.Add("Yes");
                listViewLecturers.Items.Add(li);
            }
        }
        public void ShowDrinksPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();

            // show drinks panel

            pnlDrinks.Show();

            try
            {
                // getting the drinks form the GetDrinks method and sending it to the list and then displaying
                List<Drinks> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }

            catch (Exception e)
            {
                // show error message box if there is an error
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
            }
        }
        private List<Drinks> GetDrinks()
        {
            DrinksService drinkService = new DrinksService();
            List<Drinks> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void DisplayDrinks(List<Drinks> drinks)
        {
            // clearing the list before displaying
            listViewDrinks.Items.Clear();

            foreach (Drinks drink in drinks)
            {
                // adding drinkName to listview
                ListViewItem li = new ListViewItem(drink.drinkName.ToString());
                li.Tag = drink;

                // adding data to the listview 
                li.SubItems.Add(drink.drinkType.ToString());
                li.SubItems.Add(drink.price.ToString());
                li.SubItems.Add(drink.stock.ToString());
                li.SubItems.Add(drink.VAT.ToString());
                if (drink.stock < 10)
                {
                    li.SubItems.Add("Stock nearly depleted");
                    li.SubItems[0].ForeColor = System.Drawing.Color.Red;

                }
                else
                {
                    li.SubItems.Add("Stock sufficient");
                    li.SubItems[0].ForeColor = System.Drawing.Color.Green;
                }
                listViewDrinks.Items.Add(li);
            }
        }

        private void dashboardToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }
        private void exitToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowLecturerPanel();
        }

        private void roomsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowRoomPanel();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        class ListViewItemStringComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemStringComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }

            public ListViewItemStringComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                           ((ListViewItem)y).SubItems[col].Text);

                // Determine whether the sort order is descending.
                if (order == SortOrder.Descending)
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;

                return returnVal;
            }
        }

        class ListViewItemIntComparer : IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemIntComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                int value1, value2;

                if (int.TryParse(((ListViewItem)x).SubItems[col].Text, out value1) && int.TryParse(((ListViewItem)y).SubItems[col].Text, out value2))
                {
                    returnVal = value1.CompareTo(value2);
                }

                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }

                return returnVal;
            }
        }
        

        private void listViewDrinks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != _sortColumnIndex)
            {
                // Set the sort column to the new column.
                _sortColumnIndex = e.Column;
                // Set the sort order to ascending by default.
                listViewDrinks.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewDrinks.Sorting == SortOrder.Ascending)
                    listViewDrinks.Sorting = SortOrder.Descending;
                else
                    listViewDrinks.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewDrinks.Sort();

            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            listViewDrinks.ListViewItemSorter = new ListViewItemStringComparer(e.Column, listViewDrinks.Sorting);
        }

        private SortOrder studentSortOrder = SortOrder.Ascending;
        private void studentNumberbutton_Click(object sender, EventArgs e)
        {
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their ID
            listViewStudents.ListViewItemSorter = new ListViewItemIntComparer(0, studentSortOrder);
            listViewStudents.Sort();
        }

        private void firstNameButton_Click(object sender, EventArgs e)
        {
            // Toggle between ascending and descending order
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their name (first name column is index 1)
            listViewStudents.ListViewItemSorter = new ListViewItemStringComparer(1, studentSortOrder);
            listViewStudents.Sort();
        }

        private void lastNameButton_Click(object sender, EventArgs e)
        {
            // Toggle between ascending and descending order
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their last name (last name column is index 2)
            listViewStudents.ListViewItemSorter = new ListViewItemStringComparer(2, studentSortOrder);
            listViewStudents.Sort();
        }

        private void telephoneButton_Click(object sender, EventArgs e)
        {
            // Toggle between ascending and descending order
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their phone (phone column is index 3)
            listViewStudents.ListViewItemSorter = new ListViewItemIntComparer(3, studentSortOrder);
            listViewStudents.Sort();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            // Toggle between ascending and descending order
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their class (class column is index 4)
            listViewStudents.ListViewItemSorter = new ListViewItemIntComparer(4, studentSortOrder);
            listViewStudents.Sort();
        }

        private void roomIDbutton_Click(object sender, EventArgs e)
        {
            if (studentSortOrder == SortOrder.Ascending)
            {
                studentSortOrder = SortOrder.Descending;
            }
            else
            {
                studentSortOrder = SortOrder.Ascending;
            }
            // Sort students by their class (class column is index 4)
            listViewStudents.ListViewItemSorter = new ListViewItemIntComparer(5, studentSortOrder);
            listViewStudents.Sort();
        }

        int _sortColumnIndex = -1;
        private void listViewLecturers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != _sortColumnIndex)
            {
                // Set the sort column to the new column.
                _sortColumnIndex = e.Column;
                // Set the sort order to ascending by default.
                listViewLecturers.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (listViewLecturers.Sorting == SortOrder.Ascending)
                    listViewLecturers.Sorting = SortOrder.Descending;
                else
                    listViewLecturers.Sorting = SortOrder.Ascending;
            }

            // Call the sort method to manually sort.
            listViewLecturers.Sort();

            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            listViewLecturers.ListViewItemSorter = new ListViewItemStringComparer(e.Column, listViewLecturers.Sorting);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkAdd drinkAdd = new DrinkAdd(drink);
            drinkAdd.ShowDialog();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkDelete drinkDelete = new DrinkDelete(drink);
            drinkDelete.ShowDialog();
        }

        private void bnUpdate_Click(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkUpdate drinkUpdate = new DrinkUpdate(drink);
            drinkUpdate.ShowDialog();
        }
    }
}