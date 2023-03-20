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
    public partial class DrinkDelete : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DrinkDelete(SomerenModel.Drinks drink)
        {
            InitializeComponent();

            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM DRINKS WHERE drinkName = '" + textBox_DrinkName.Text+"'";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();

            MessageBox.Show("Drink deleted");
        }
    }
}
