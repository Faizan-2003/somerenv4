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

namespace SomerenUI
{
    public partial class ActivityDeleteForm : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public ActivityDeleteForm(SomerenModel.Activity activity)
        {
            InitializeComponent();

            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM ACTIVITY WHERE ActivityId = {txtactivityIDdel.Text}";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();

            MessageBox.Show($"Activity (activity ID: {txtactivityIDdel.Text}) is deleted!");
        }
    }
}
