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
    public partial class ActivityUpdateForm : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public ActivityUpdateForm(SomerenModel.Activity activity)
        {
            InitializeComponent();

            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();

        }
        private void dateTimeStartUpd_ValueChanged(object sender, EventArgs e)
        {
            dateTimeStartUpd.Format = DateTimePickerFormat.Time;
        }

        private void dateTimeEndUpd_ValueChanged(object sender, EventArgs e)
        {
            dateTimeEndUpd.Format = DateTimePickerFormat.Time;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE ACTIVITY SET ActivityId = {txtActivityidUpd.Text},  ActivityName={txtActivitynameUpd}, StartDateTime={dateTimeStartUpd}, EndDateTime={dateTimeEndUpd} WHERE ActivityId={txtActivityidUpd}";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            MessageBox.Show($"Activity (activity ID: {txtActivityidUpd.Text}) is updated");
        }
    }
}
