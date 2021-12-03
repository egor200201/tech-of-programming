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
using MaterialSkin;
using MaterialSkin.Controls;
namespace myproject
{
    public partial class Formadmin : Form
    {
        SqlConnection sqlConnection;

        public Formadmin()
        {
            InitializeComponent();
        } 
        private async void Formadmin_Load(object sender, EventArgs e)
        {
            //Change this path "C:\Users\HOME\Desktop\c#\WorkingWithDB\WorkingWithDB\Database.mdf" for your own computer
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Егор\source\repos\myproject\myproject\Database.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Medicaldb]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "    " + Convert.ToString(sqlReader["Patientname"]) + "       " + Convert.ToString(sqlReader["Patientsurname"]) + "       " + Convert.ToString(sqlReader["Date"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }




        private void Formadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }






        private async void Buttondelete_Click(object sender, EventArgs e)
        {
            if (label8.Visible)
                label8.Visible = false;

            if (!string.IsNullOrEmpty(txtiddelete.Text) && !string.IsNullOrWhiteSpace(txtiddelete.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Medicaldb] WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id", txtiddelete.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label8.Visible = true;

                label8.Text = "Id должнен быть заполнен!";
            }
        }

 

      

        private async void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (updatemistake.Visible)
                updatemistake.Visible = false;

            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Medicaldb] SET [Patientname]=@Patientname, [Patientsurname]=@Patientsurname, [Date]=@Date WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox7.Text);
                command.Parameters.AddWithValue("Patientname", textBox4.Text);
                command.Parameters.AddWithValue("Patientsurname", textBox5.Text);
                command.Parameters.AddWithValue("Date", textBox6.Text);

                await command.ExecuteNonQueryAsync();
            }
            else {
                updatemistake.Visible = true;

                updatemistake.Text = "not enough information !";
            }

             
        }


        private async void Button1_Click(object sender, EventArgs e)
        {

            if (insertmistake.Visible)
                insertmistake.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)&&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Medicaldb] (Patientname, Patientsurname,Date)VALUES(@Patientname, @Patientsurname,@Date)", sqlConnection);

                command.Parameters.AddWithValue("Patientname", textBox1.Text);

                command.Parameters.AddWithValue("Patientsurname", textBox2.Text);
                command.Parameters.AddWithValue("Date", textBox3.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                insertmistake.Visible = true;

                insertmistake.Text = "not enough information !";
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void apdateDbToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Medicaldb]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "    " + Convert.ToString(sqlReader["Patientname"]) + "       " + Convert.ToString(sqlReader["Patientsurname"]) + "       " + Convert.ToString(sqlReader["Date"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
