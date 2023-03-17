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
            roomIDbutton = new System.Windows.Forms.Button();
            classButton = new System.Windows.Forms.Button();
            telephoneButton = new System.Windows.Forms.Button();
            lastNameButton = new System.Windows.Forms.Button();
            firstNameButton = new System.Windows.Forms.Button();
            studentNumberbutton = new System.Windows.Forms.Button();
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
            listViewRooms = new System.Windows.Forms.ListView();
            roomnumber = new System.Windows.Forms.ColumnHeader();
            roomType = new System.Windows.Forms.ColumnHeader();
            capacity = new System.Windows.Forms.ColumnHeader();
            Floor = new System.Windows.Forms.ColumnHeader();
            buildingId = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
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
            pnlStudents.Controls.Add(roomIDbutton);
            pnlStudents.Controls.Add(classButton);
            pnlStudents.Controls.Add(telephoneButton);
            pnlStudents.Controls.Add(lastNameButton);
            pnlStudents.Controls.Add(firstNameButton);
            pnlStudents.Controls.Add(studentNumberbutton);
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 622);
            pnlStudents.TabIndex = 2;
            // 
            // roomIDbutton
            // 
            roomIDbutton.Location = new System.Drawing.Point(777, 56);
            roomIDbutton.Name = "roomIDbutton";
            roomIDbutton.Size = new System.Drawing.Size(116, 29);
            roomIDbutton.TabIndex = 10;
            roomIDbutton.Text = "Room ID";
            roomIDbutton.UseVisualStyleBackColor = true;
            roomIDbutton.Click += button6_Click;
            // 
            // classButton
            // 
            classButton.Location = new System.Drawing.Point(627, 56);
            classButton.Name = "classButton";
            classButton.Size = new System.Drawing.Size(144, 29);
            classButton.TabIndex = 9;
            classButton.Text = "Class";
            classButton.UseVisualStyleBackColor = true;
            classButton.Click += button5_Click;
            // 
            // telephoneButton
            // 
            telephoneButton.Location = new System.Drawing.Point(478, 56);
            telephoneButton.Name = "telephoneButton";
            telephoneButton.Size = new System.Drawing.Size(143, 29);
            telephoneButton.TabIndex = 8;
            telephoneButton.Text = "Telephone";
            telephoneButton.UseVisualStyleBackColor = true;
            telephoneButton.Click += button4_Click;
            // 
            // lastNameButton
            // 
            lastNameButton.Location = new System.Drawing.Point(327, 56);
            lastNameButton.Name = "lastNameButton";
            lastNameButton.Size = new System.Drawing.Size(145, 29);
            lastNameButton.TabIndex = 7;
            lastNameButton.Text = "Last Name";
            lastNameButton.UseVisualStyleBackColor = true;
            lastNameButton.Click += button3_Click;
            // 
            // firstNameButton
            // 
            firstNameButton.Location = new System.Drawing.Point(176, 56);
            firstNameButton.Name = "firstNameButton";
            firstNameButton.Size = new System.Drawing.Size(145, 29);
            firstNameButton.TabIndex = 6;
            firstNameButton.Text = "First Name";
            firstNameButton.UseVisualStyleBackColor = true;
            firstNameButton.Click += button2_Click;
            // 
            // studentNumberbutton
            // 
            studentNumberbutton.Location = new System.Drawing.Point(18, 56);
            studentNumberbutton.Name = "studentNumberbutton";
            studentNumberbutton.Size = new System.Drawing.Size(152, 29);
            studentNumberbutton.TabIndex = 5;
            studentNumberbutton.Text = "Student Number";
            studentNumberbutton.UseVisualStyleBackColor = true;
            studentNumberbutton.Click += button1_Click_1;
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
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label2);
            pnlRooms.Location = new System.Drawing.Point(14, 36);
            pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 622);
            pnlRooms.TabIndex = 3;
            pnlRooms.Paint += pnlRooms_Paint;
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
            // pnlLecturers
            // 
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
            listViewLecturers.Location = new System.Drawing.Point(18, 56);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 408);
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
        private System.Windows.Forms.ColumnHeader roomnumber;
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
        private System.Windows.Forms.Button roomIDbutton;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button telephoneButton;
        private System.Windows.Forms.Button lastNameButton;
        private System.Windows.Forms.Button firstNameButton;
        private System.Windows.Forms.Button studentNumberbutton;
    }
}