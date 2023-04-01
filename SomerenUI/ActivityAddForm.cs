using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class ActivityAddForm : Form
    {
        private SqlConnection connection;
        private SqlCommand command;

        public ActivityAddForm(SomerenModel.Activity activity)
        {
            InitializeComponent();
            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO ACTIVITY VALUES ({txtActivityidAdd.Text}, {txtActivitynameAdd.Text}, {dateTimeStartAdd.Text}, {dateTimeEndAdd.Text})";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            MessageBox.Show($"Activity {txtActivitynameAdd.Text} is added to the Database!");
        }

        private void dateTimeStartAdd_ValueChanged(object sender, EventArgs e)
        {
            dateTimeStartAdd.Format = DateTimePickerFormat.Time;
        }

        private void dateTimeEndAdd_ValueChanged(object sender, EventArgs e)
        {
            dateTimeEndAdd.Format = DateTimePickerFormat.Time;
        }
    }
}
