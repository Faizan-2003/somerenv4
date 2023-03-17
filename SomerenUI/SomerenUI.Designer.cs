namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
<<<<<<< Updated upstream
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.pnlLecturers = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listViewLecturers = new System.Windows.Forms.ListView();
            this.LecturerId = new System.Windows.Forms.ColumnHeader();
            this.firstName = new System.Windows.Forms.ColumnHeader();
            this.lastName = new System.Windows.Forms.ColumnHeader();
            this.telephone = new System.Windows.Forms.ColumnHeader();
            this.age = new System.Windows.Forms.ColumnHeader();
            this.roomId = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlRooms.SuspendLayout();
            this.pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click_1);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(14, 36);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1072, 622);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(15, 18);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(262, 20);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.pnlRooms);
            this.pnlStudents.Controls.Add(this.pictureBox1);
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.label1);
            this.pnlStudents.Location = new System.Drawing.Point(14, 36);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1072, 622);
            this.pnlStudents.TabIndex = 2;
            // 
            // pnlRooms
            // 
            this.pnlRooms.Controls.Add(this.pictureBox2);
            this.pnlRooms.Controls.Add(this.listViewRooms);
            this.pnlRooms.Controls.Add(this.label2);
            this.pnlRooms.Location = new System.Drawing.Point(0, 0);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(1072, 622);
            this.pnlRooms.TabIndex = 3;
=======
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            listViewRooms = new System.Windows.Forms.ListView();
            roomnumber = new System.Windows.Forms.ColumnHeader();
            roomType = new System.Windows.Forms.ColumnHeader();
            capacity = new System.Windows.Forms.ColumnHeader();
            Floor = new System.Windows.Forms.ColumnHeader();
            buildingId = new System.Windows.Forms.ColumnHeader();
            pnlLecturers = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            firstName = new System.Windows.Forms.ColumnHeader();
            lastName = new System.Windows.Forms.ColumnHeader();
            telephone = new System.Windows.Forms.ColumnHeader();
            age = new System.Windows.Forms.ColumnHeader();
            roomId = new System.Windows.Forms.ColumnHeader();
            isSupervisor = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1099, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click_1;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 622);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 18);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(button6);
            pnlStudents.Controls.Add(button5);
            pnlStudents.Controls.Add(button4);
            pnlStudents.Controls.Add(button3);
            pnlStudents.Controls.Add(button2);
            pnlStudents.Controls.Add(button1);
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 622);
            pnlStudents.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(775, 56);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(118, 29);
            button6.TabIndex = 8;
            button6.Text = "Room ID";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(620, 56);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(149, 29);
            button5.TabIndex = 7;
            button5.Text = "Class";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(477, 56);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(137, 29);
            button4.TabIndex = 6;
            button4.Text = "Telephone";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(318, 55);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(153, 29);
            button3.TabIndex = 5;
            button3.Text = "Last Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(177, 56);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 29);
            button2.TabIndex = 4;
            button2.Text = "First Name";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(18, 56);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(153, 29);
            button1.TabIndex = 3;
            button1.Text = "Student Number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 408);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Student Number";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First Name";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Last Name";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telephone";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Class";
            columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Room ID";
            columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(18, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox2);
            pnlRooms.Controls.Add(label2);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(14, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 622);
            pnlRooms.TabIndex = 3;
            pnlRooms.Paint += pnlRooms_Paint;
>>>>>>> Stashed changes
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(149, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 41);
            label2.TabIndex = 0;
            label2.Text = "Rooms";
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { roomnumber, roomType, capacity, Floor, buildingId });
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 408);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomnumber
            // 
            roomnumber.Text = "Room Number";
            roomnumber.Width = 150;
            // 
            // roomType
            // 
            roomType.Text = "Room Type";
            roomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            roomType.Width = 200;
            // 
            // capacity
            // 
            capacity.Text = "Capacity";
            capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            capacity.Width = 150;
            // 
            // Floor
            // 
            Floor.Text = "Floor";
            Floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Floor.Width = 150;
            // 
            // buildingId
            // 
            buildingId.Text = "Building ID";
            buildingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            buildingId.Width = 150;
            // 
            // pnlLecturers
            // 
<<<<<<< Updated upstream
            this.pnlLecturers.Controls.Add(this.pictureBox3);
            this.pnlLecturers.Controls.Add(this.listViewLecturers);
            this.pnlLecturers.Controls.Add(this.label3);
            this.pnlLecturers.Location = new System.Drawing.Point(14, 36);
            this.pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLecturers.Name = "pnlLecturers";
            this.pnlLecturers.Size = new System.Drawing.Size(1072, 622);
            this.pnlLecturers.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(920, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 164);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // listViewLecturers
            // 
            this.listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LecturerId,
            this.firstName,
            this.lastName,
            this.telephone,
            this.age,
            this.roomId});
            this.listViewLecturers.Location = new System.Drawing.Point(18, 56);
            this.listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewLecturers.Name = "listViewLecturers";
            this.listViewLecturers.Size = new System.Drawing.Size(875, 408);
            this.listViewLecturers.TabIndex = 0;
            this.listViewLecturers.UseCompatibleStateImageBehavior = false;
            this.listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // LecturerId
            // 
            this.LecturerId.Text = "LecturerId";
            this.LecturerId.Width = 90;
            // 
            // firstName
            // 
            this.firstName.Text = "firstName";
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstName.Width = 111;
            // 
            // lastName
            // 
            this.lastName.Text = "lastName";
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastName.Width = 111;
            // 
            // telephone
            // 
            this.telephone.Text = "telephone";
            this.telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telephone.Width = 111;
            // 
            // age
            // 
            this.age.Text = "age";
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age.Width = 75;
            // 
            // roomId
            // 
            this.roomId.Text = "roomId";
            this.roomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roomId.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lecturers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(920, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 164);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRooms.Location = new System.Drawing.Point(18, 56);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(875, 408);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firstname";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Number";
            this.columnHeader4.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rooms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(920, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 164);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewStudents.Location = new System.Drawing.Point(18, 56);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(875, 408);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "studentID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "student Number";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "First Name";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Last Name";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "telephone";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Class";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Room ID";
            this.columnHeader9.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 674);
            this.Controls.Add(this.pnlLecturers);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlRooms.ResumeLayout(false);
            this.pnlRooms.PerformLayout();
            this.pnlLecturers.ResumeLayout(false);
            this.pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

=======
            pnlLecturers.Controls.Add(pictureBox3);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label3);
            pnlLecturers.Location = new System.Drawing.Point(14, 36);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1072, 622);
            pnlLecturers.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(149, 164);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { firstName, lastName, telephone, age, roomId, isSupervisor });
            listViewLecturers.Location = new System.Drawing.Point(18, 55);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 409);
            listViewLecturers.TabIndex = 0;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            listViewLecturers.ColumnClick += listViewLecturers_ColumnClick;
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            firstName.Width = 150;
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            lastName.Width = 150;
            // 
            // telephone
            // 
            telephone.Text = "Telephone";
            telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            telephone.Width = 150;
            // 
            // age
            // 
            age.Text = "Age";
            age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            age.Width = 150;
            // 
            // roomId
            // 
            roomId.Text = "Room ID";
            roomId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            roomId.Width = 150;
            // 
            // isSupervisor
            // 
            isSupervisor.Text = "Supervisor";
            isSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            isSupervisor.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(138, 41);
            label3.TabIndex = 0;
            label3.Text = "Lecturers";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 674);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlRooms);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
>>>>>>> Stashed changes
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listViewRooms;
<<<<<<< Updated upstream
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
=======
        private System.Windows.Forms.ColumnHeader roomnumber;
>>>>>>> Stashed changes
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader roomId;
<<<<<<< Updated upstream
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
=======
        private System.Windows.Forms.ColumnHeader roomType;
        private System.Windows.Forms.ColumnHeader Floor;
        private System.Windows.Forms.ColumnHeader buildingId;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader capacity;
        private System.Windows.Forms.ColumnHeader isSupervisor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
>>>>>>> Stashed changes
    }
}