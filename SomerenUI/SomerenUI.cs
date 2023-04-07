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
using SomerenDAL;
using System.Windows.Forms.VisualStyles;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();

            // disable the delete button if no row is selected.
            btnDeleteItem.Enabled = false;

            // disable the checkout button if unsufficient rows are selected.
            btncheckout.Enabled = false;
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();

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
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();

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
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();

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
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();

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
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);
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
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();

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

            DrinksService drinksService = new DrinksService();
            foreach (Drinks drink in drinks)
            {
                // adding drinkName to listview
                ListViewItem li = new ListViewItem(drink.drinkName.ToString());
                li.Tag = drink;


                // adding data to the listview 
                li.SubItems.Add(drink.drinkType.ToString());
                li.SubItems.Add(drink.drinkPrice.ToString());
                li.SubItems.Add(drink.stock.ToString());
                li.SubItems.Add(drink.VAT.ToString());
                li.SubItems.Add(drinksService.GetTotalSales(drink.drinkName));
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
        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Showing the cash register panel
            ShowCashRegisterPanel();
        }
        private void DisplayCashRegister(List<Student> students, List<Drinks> drinks)
        {

            listviewnames.Items.Clear();

            // getting students data
            foreach (Student student in students)
            {
                // student data in list view
                ListViewItem list = new ListViewItem(student.StudentId.ToString());
                list.Tag = students;

                list.SubItems.Add(student.FirstName.ToString());
                list.SubItems.Add(student.LastName.ToString());

                // adding student items in list
                listviewnames.Items.Add(list);
            }
            listViewdrinkcash.Items.Clear();

            // getting drinks data
            foreach (Drinks drink in drinks)
            {
                // drinks data in list view
                ListViewItem list = new ListViewItem(drink.drinkId.ToString());
                list.Tag = drink;

                list.SubItems.Add(drink.drinkName.ToString());
                list.SubItems.Add(drink.drinkPrice.ToString());
                list.SubItems.Add(drink.stock.ToString());
                list.SubItems.Add(drink.drinkType.ToString());

                // adding drink items in list
                listViewdrinkcash.Items.Add(list);
            }
        }
        private void CheckOutButtonEnable()
        {
            if (listViewdrinkcash.SelectedItems.Count > 0 && listviewnames.SelectedItems.Count > 0)
            {
                // show the proce of the selected drink and display in the textbox
                int price = int.Parse(listViewdrinkcash.SelectedItems[0].SubItems[2].Text);
                txtTotalAmount.Text = price.ToString();

                // enabling the checkout button once the sufficient amount of rows are selected.
                btncheckout.Enabled = true;
            }
            else
            {
                // if no price then is selected show 000
                txtTotalAmount.Text = "0.00";
                btncheckout.Enabled = false;
            }
        }
        private void UnselectListviewItem(System.Windows.Forms.ListView listView)
        {
            // unselecting the selected rows after adding the data to the database
            if (listView.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < listView.SelectedIndices.Count; i++)
                {
                    listView.Items[listView.SelectedIndices[i]].Selected = false;
                }
            }
        }
        private void btncheckout_Click_1(object sender, EventArgs e)
        {
            //getting the selected data  from the listview
            int studentID = int.Parse(listviewnames.SelectedItems[0].SubItems[0].Text);
            int drinkID = int.Parse(listViewdrinkcash.SelectedItems[0].SubItems[0].Text);

            // assigning the selected rows to the variables from the class Order.
            Order order = new Order();
            order.studentID = studentID;
            order.drinkID = drinkID;

            // try the code
            try
            {
                // calling the method from the service layer made in the DAO
                OrderService orderService = new OrderService();
                orderService.DrinkOrdering(order);

                // shpwing the order completion message after success.
                MessageBox.Show($"Order Check Out Successfully! \nStudent Number: {studentID} bought Drink ID: {drinkID}.", "Successful");

                // calling the unselect method to order more drinks.
                UnselectListviewItem(listViewdrinkcash);
                UnselectListviewItem(listviewnames);
            }

            // throw an error if the try does not work
            catch (Exception exp)
            {
                // Error message
                MessageBox.Show("Something went Wrong while checking out... \n" + exp.Message, "Error!");
            }
        }

        public void HideAllpanelForCash()
        {
            //hiding ALL OTHER panels
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlActivity.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();
        }

        public void HideAllpanelForActivity()
        {
            //hiding ALL OTHER panels
            pnlStudents.Hide();
            pnlLecturers.Hide();    
            pnlRooms.Hide();    
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
            pnlRevenue.Hide();
            pnlParticipants.Hide();
        }
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            HideAllpanelForActivity();

            // show the activity panel
            pnlActivity.Show();

            try
            {
                // getting the activities form the GetActivities method and sending it to the list and then displaying
                List<Activities> activities = GetActivities();
                DisplayActivities(activities);
            }

            // throw an exception if try does not work
            catch (Exception e)
            {
                // show error message box if there is an error
                MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
            }
        }
        private List<Activities> GetActivities()
        {
            // Get the activites from the GetActivities method
            ActivityService activityService = new ActivityService();
            List<Activities> activities = activityService.GetActivities();

            // return the activities.
            return activities;
        }

        private void DisplayActivities(List<Activities> activities)
        {
            // clear the listview before filling it
            listViewActivity.Items.Clear();

            foreach (Activities activity in activities)
            {

                ListViewItem li = new ListViewItem(activity.activityId.ToString());
                li.Tag = activity;

                li.SubItems.Add(activity.activityName.ToString());
                li.SubItems.Add(activity.startTime.ToString());
                li.SubItems.Add(activity.endTime.ToString());

                // adding all the data to the list
                listViewActivity.Items.Add(li);
            }
        }
        private void ShowCashRegisterPanel()
        {
            // hide all panels
            HideAllpanelForCash();

            // show cash register panel
            pnlCashRegister.Show();

            try
            {
                // getting the students form the GetStudents method and sending it to the list and then displaying in cash register
                List<Student> students = GetStudents();
                List<Drinks> drink = GetDrinks();
                DisplayCashRegister(students, drink);
            }
            catch (Exception e)
            {
                // show error message box if there is an error
                MessageBox.Show("Something went wrong while loading the Cash Register: " + e.Message);
            }
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
       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkAdd drinkAdd = new DrinkAdd(drink);
            drinkAdd.ShowDialog();
        }
        private void bnUpdate_Click_1(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkUpdate drinkUpdate = new DrinkUpdate(drink);
            drinkUpdate.ShowDialog();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Drinks drink = new Drinks();
            DrinkDelete drinkDelete = new DrinkDelete(drink);
            drinkDelete.ShowDialog();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // refresh the drink panel
            ShowDrinksPanel();
        }

        

        private RevenueService revenueService = new RevenueService();
        private List<Revenue> allRevenues;
        private void ShowRevenuePanel()
        {
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlRooms.Hide();
            pnlDashboard.Hide();
            pnlDrinks.Hide();
            pnlCashRegister.Hide();
            pnlActivity.Hide();
            pnlParticipants.Hide();

            pnlRevenue.Show();

            try
            {
                // Set the DateTimePicker's value to the current date
                dateTimePicker1.Value = DateTime.Now;

                // Get and display revenues for the current date
                List<Revenue> revenues = revenueService.GetRevenues(dateTimePicker1.Value);
                DisplayRevenue(revenues);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the revenues: " + e.Message);
            }
        }

        private void DisplayRevenue(List<Revenue> revenues)
        {
            // Clearing the list before displaying
            listViewRevenue.Items.Clear();
            float overallProfit = 0;
            foreach (Revenue revenue in revenues)
            {
                ListViewItem li = new ListViewItem(revenue.drinkName.ToString());
                li.Tag = revenue;
                li.SubItems.Add(revenue.drinkType);
                li.SubItems.Add($"{revenue.price:C}");
                li.SubItems.Add(revenue.stock.ToString());
                li.SubItems.Add(revenue.sales.ToString());
                float drinkProfit = revenue.price * revenue.sales;

                overallProfit = overallProfit + drinkProfit;

                li.SubItems.Add($"{drinkProfit:C}");
                listViewRevenue.Items.Add(li);
            }
            // Update label13.Text to display the overall profit
            label13.Text = overallProfit.ToString("C");
        }

        public List<Revenue> GetRevenues(DateTime selectedDate)
        {
            RevenueService revenueService = new RevenueService();
            List<Revenue> revenues = revenueService.GetRevenues(selectedDate);
            return revenues;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DateTime selectedDate = dateTimePicker1.Value;

                if (selectedDate.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Please select a date that is in the current or past.", "Warning!");
                    return;
                }
                else
                {
                    allRevenues = revenueService.GetRevenues(selectedDate);

                    DisplayRevenue(allRevenues);

                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            allRevenues = revenueService.GetRevenues(dateTimePicker1.Value);
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void dashboardToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void activitiesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
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

        private void cashRegisterToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            ShowCashRegisterPanel();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listviewnames_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CheckOutButtonEnable();
        }

        private void listViewdrinkcash_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOutButtonEnable();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sports = new List<string>() { "No activity", "Zumba", "Football", "Handball", "Kickbox", "Boxing", "Eating" };

            string activity = comboBox1.SelectedItem.ToString();

            if (!sports.Contains(activity))
            {
                MessageBox.Show("Invalid activity.");
                return;
            }

            List<studentParticipationModel> matchingItems = new List<studentParticipationModel>();

            foreach (studentParticipationModel student in allStudentParticipations)
            {
                if (student.ActivityName == activity)
                {
                    matchingItems.Add(student);
                }
            }

            listView2.Items.Clear();
            foreach (studentParticipationModel student in matchingItems)
            {
                ListViewItem li = new ListViewItem(student.ActivityName.ToString());
                li.Tag = student;

                li.SubItems.Add(student.FirstName.ToString());
                li.SubItems.Add(student.LastName.ToString());

                listView2.Items.Add(li);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 addRemoveStudnet = new Form1();
            addRemoveStudnet.ShowDialog();
        }

        public void ShowStudentParticipation()
        {
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlLecturers.Hide();
            pnlDrinks.Hide();
            pnlRevenue.Hide();
            pnlCashRegister.Hide();
            pnlStudents.Hide();
            pnlActivity.Hide();

            pnlParticipants.Show();

            try
            {
                // getting the lecturers form the GetLecturers method and sending it to the list and then displaying
                List<studentParticipationModel> studenntsParticipents = GetStudentParticipents();
                DisplayStudentParticipents(studenntsParticipents);
            }

            catch (Exception e)
            {
                // show error message box if there is an error
                MessageBox.Show("Something went wrong while loading the studentParticipents: " + e.Message);
            }
        }
        private List<studentParticipationModel> allStudentParticipations;
        private void DisplayStudentParticipents(List<studentParticipationModel> studentParticipations)
        {
            allStudentParticipations = studentParticipations;

            listView2.Items.Clear();

            foreach (studentParticipationModel student in studentParticipations)
            {
                ListViewItem li = new ListViewItem(student.ActivityName.ToString());
                li.Tag = student;

                li.SubItems.Add(student.FirstName.ToString());
                li.SubItems.Add(student.LastName.ToString());

                listView2.Items.Add(li);
            }
        }
        private List<studentParticipationModel> GetStudentParticipents()
        {
            StudnetParticipationService studentParticipents = new StudnetParticipationService();
            List<studentParticipationModel> students = studentParticipents.GetStudnetParticipetns();
            return students;
        }
        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentParticipation();
        }

        private void studentNumberbutton_Click_1(object sender, EventArgs e)
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

        private void firstNameButton_Click_1(object sender, EventArgs e)
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

        private void lastNameButton_Click_1(object sender, EventArgs e)
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

        private void telephoneButton_Click_1(object sender, EventArgs e)
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

        private void classButton_Click_1(object sender, EventArgs e)
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

        private void roomIDbutton_Click_1(object sender, EventArgs e)
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

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            // try to add an activity
            try
            {
                // making a new variable from the class Activities.
                Activities activities = new Activities();

                // assigning the data entered in the textbox and datetimepicker to the variables in class Activities.
                activities.activityName = txtActivityName.Text;
                activities.startTime = DateTime.Parse(dateTimeStart.Text);
                activities.endTime = DateTime.Parse(dateTimeEnd.Text);

                // making a new variable from the class ActivitiesService to get the methood to Update.
                ActivityService activity = new ActivityService();

                // calling the method from the activity service which is made in DAO.
                activity.ActivityAdd(activities);

                // Show a message of success if the activity is addeed successfully...
                MessageBox.Show($"New Activity: {txtActivityName.Text} is added successfully!", "Successful");
            }

            // throw an exception if the try doesn't work...
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while Adding an Activity! \n" + exp.Message, "Error!");
            }

            //refresh the list
            ShowActivitiesPanel();
        }

        private void btnRefreshlist_Click_1(object sender, EventArgs e)
        {
            // refresh the activity panel 
            ShowActivitiesPanel();

            // reset all the textboxes and dateatimepickers to add more data
            txtActivityID.Clear();
            txtActivityName.Clear();
            dateTimeStart.ResetText();
            dateTimeEnd.ResetText();
        }

        private void btnUpdateItem_Click_1(object sender, EventArgs e)
        {
            // try to update the selected activity
            try
            {
                // check if the selected number of greater then 0 to see if the row is selected or not...
                if (listViewActivity.SelectedItems.Count > 0)
                {
                    // converting the selected item into (class)Activities and assigning the selected row to activities(variable)
                    Activities activities = (Activities)listViewActivity.SelectedItems[0].Tag;

                    // assigning the data entered in the textbox and datetimepicker to the variables in class Activities.
                    activities.activityName = txtActivityName.Text;
                    activities.startTime = DateTime.Parse(dateTimeStart.Text);
                    activities.endTime = DateTime.Parse(dateTimeEnd.Text);

                    // making a new variable from the class ActivitiesService to get the methood to Update.
                    ActivityService activity = new ActivityService();

                    // calling the method from the activity service which is made in DAO.
                    activity.ActivityUpdate(activities);
                }
                //show an error if the above code doesn't work.
                else
                {
                    // error message
                    MessageBox.Show("No activity is Affected", "Failed!");

                    // return as the code is not working
                    return;
                }
            }
            // throw an exception if the try doesn't work...
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while Updating an Activity! \n" + exp.Message, "Error!");
            }
            // refresh the list
            ShowActivitiesPanel();
        }

        private void btnDeleteItem_Click_1(object sender, EventArgs e)
        {
            // parse the selected row into int...
            int activityId = int.Parse(listViewActivity.SelectedItems[0].SubItems[0].Text);

            // making a new variable from the class Activities.
            Activities activities = new Activities();

            // assigning the selected row to the variable activityId in class Activities
            activities.activityId = activityId;

            // try to delete the selected activity.
            try
            {
                ActivityService activity = new ActivityService();
                // ask to make sure if they want to delete.
                DialogResult dialogResult = MessageBox.Show("Are you sure that you wish to remove this activity?", "Confirmation", MessageBoxButtons.YesNo);

                // if they agree then delete the activity...
                if (dialogResult == DialogResult.Yes)
                {
                    activity.ActivityDelete(activities);
                    MessageBox.Show("Activity deleted successfully", "Successful");
                }
                //if they disagree then don't do anything...
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Activity is not deleted", "Successful");
                }
            }
            // throw an exception if the try method doesn't work...
            catch (Exception exp)
            {
                MessageBox.Show("Something went wrong while deleting an Activity! \n" + exp.Message, "Error!");
            }

            //refresh the list
            ShowActivitiesPanel();
        }

        private void listViewActivity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // enable the delete button if the row is selected in acticities..
            btnDeleteItem.Enabled = (listViewActivity.SelectedItems.Count >= 0);

            // check the user has selected any row...
            if (listViewActivity.SelectedItems.Count > 0)
            {

                // converting the selected item into (class)Activities and assigning the selected row to activities(variable)
                Activities activities = (Activities)listViewActivity.SelectedItems[0].Tag;

                // assigning the data entered in the textbox and datetimepicker to the variables in class Activities.
                txtActivityID.Text = activities.activityId.ToString();
                txtActivityName.Text = activities.activityName.ToString();
                dateTimeStart.Text = activities.startTime.ToString();
                dateTimeEnd.Text = activities.endTime.ToString();
            }
            // show an error and return if no enough no
            else
            {
                MessageBox.Show("Not Enough Number of Row Selected", "Failed!");
                return;
            }
        }
    }
}