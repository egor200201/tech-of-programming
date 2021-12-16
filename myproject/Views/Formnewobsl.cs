using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MaterialSkin;
using MaterialSkin.Controls;
namespace myproject
{
    public partial class Formnewobsl : MaterialForm
    {
        static public int typeofact1;
        static public int pressensor1;
        static public int tempsensor1;
        static public int moistsensor1;
        static public int ratesensor1;
        static public int elsensor1;
        SqlConnection sqlConnection;
        public Formnewobsl()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private async void Formnewobsl_Load(object sender, EventArgs e)
        {
            //Change this path "C:\Users\HOME\Desktop\c#\WorkingWithDB\WorkingWithDB\Database.mdf" for your own computer
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Егор\source\repos\myproject\myproject\Database.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            
            if (inmistake.Visible)
                inmistake.Visible = false;

            if (!string.IsNullOrEmpty(txtPatientname.Text) && !string.IsNullOrWhiteSpace(txtPatientname.Text) &&
                !string.IsNullOrEmpty(txtPatientsurname.Text) && !string.IsNullOrWhiteSpace(txtPatientsurname.Text) &&
                !string.IsNullOrEmpty(txtDate.Text) && !string.IsNullOrWhiteSpace(txtDate.Text))
            {

                this.Hide(); // скрываем Form1 (this - текущая форма)
                Formsensor Formsensor = new Formsensor();
                Formsensor.Show(); // отображаем Form2
                SqlCommand command = new SqlCommand("INSERT INTO [Medicaldb] (Patientname, Patientsurname,Date)VALUES(@Patientname, @Patientsurname,@Date)", sqlConnection);

                command.Parameters.AddWithValue("Patientname", txtPatientname.Text);

                command.Parameters.AddWithValue("Patientsurname", txtPatientsurname.Text);
                command.Parameters.AddWithValue("Date", txtDate.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                inmistake.Visible = true;

                inmistake.Text = "not enough information !";
            }

        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            typeofact1 = 1;

        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
        typeofact1 = 2;
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           typeofact1 = 3;

        }

        private void presureCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
           pressensor1 = 1;


        }

        private void tempCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            tempsensor1 = 1;

        }

        private void moisturerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            moistsensor1 = 1;
        }

        private void ElCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            elsensor1 = 1;
        }

        private void rateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ratesensor1 = 1;
        }
    }
}
