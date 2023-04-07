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
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            {
                int studentId = int.Parse(textBox2.Text);
                string studentName = textBox1.Text;
                int activityId = comboBox1.SelectedIndex;

                string checkStudentSql = $"SELECT COUNT(*) FROM STUDENT WHERE StudentId = {studentId}";
                SqlCommand checkStudentCommand = new SqlCommand(checkStudentSql, connection);
                int studentCount = (int)checkStudentCommand.ExecuteScalar();

                if (studentCount == 0)
                {
                    MessageBox.Show($"Student with ID {studentId} does not exist.");
                    return;
                }

                string checkActivitySql = $"SELECT COUNT(*) FROM ACTIVITIES WHERE activityId = {activityId}";
                SqlCommand checkActivityCommand = new SqlCommand(checkActivitySql, connection);
                int activityCount = (int)checkActivityCommand.ExecuteScalar();

                if (activityCount == 0)
                {
                    MessageBox.Show($"Activity with ID {activityId} does not exist.");
                    return;
                }

                string sql = $"INSERT INTO PARTICIPATE (StudentId, activityId) VALUES ({studentId}, {activityId})";
                SqlCommand command = new SqlCommand(sql, connection);

                int result = command.ExecuteNonQuery();
                MessageBox.Show($"Added {studentName} (ID: {studentId}) to activity {comboBox1.SelectedItem.ToString()}.");

            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(textBox2.Text);
            string studentName = textBox1.Text;
            int activityId = comboBox1.SelectedIndex;

            string checkSql = $"SELECT COUNT(*) FROM PARTICIPATE WHERE StudentId = {studentId} AND activityId = {activityId}";
            SqlCommand checkCommand = new SqlCommand(checkSql, connection);
            int count = (int)checkCommand.ExecuteScalar();

            if (count > 0)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {studentName} (ID: {studentId}) from activity {comboBox1.SelectedItem.ToString()}?", "Confirm Removal", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM PARTICIPATE WHERE StudentId = {studentId} AND activityId = {activityId}";
                    SqlCommand command = new SqlCommand(sql, connection);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"Removed {studentName} (ID: {studentId}) from activity {comboBox1.SelectedItem.ToString()}.");
                }
            }
            else
            {
                MessageBox.Show($"{studentName} (ID: {studentId}) is not participating in the selected activity.");
            }
        }

    }
}
