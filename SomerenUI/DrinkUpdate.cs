using SomerenModel;
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
    public partial class DrinkUpdate : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DrinkUpdate(Drinks drink)
        {
            InitializeComponent();
            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE DRINKS SET drinkName = '"+textBox_DrinkName.Text+"', drinkType='"+textBox_DrinkType.Text+"', price='"+textBox_Price.Text+"', stock='"+textBox_Stock.Text+"', VAT='"+textBox_VAT.Text+"' WHERE drinkId ='"+textBox_DrinkID.Text+"'";
            command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            MessageBox.Show("Drink updated");
        }
    }
}
