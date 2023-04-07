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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SomerenUI
{
    public partial class DrinkAdd : Form
    {
        private SqlConnection connection;
        private SqlCommand command;

        public DrinkAdd(SomerenModel.Drinks drink)
        {
            InitializeComponent();
            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO DRINKS VALUES (" + textBox_DrinkID.Text + "," + "'" + textBox_DrinkName.Text + "'" + "," + "'" + textBox_DrinkType.Text + "'" + "," + "'" + textBox_Price.Text + "'" + "," + "'" + textBox_Stock.Text + "'" + "," + "'" + textBox_VAT.Text + "'" + ")";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            MessageBox.Show("Drink added");
        }
    }
}
