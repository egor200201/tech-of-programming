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
        SqlConnection sqlConnection;
        public Formnewobsl()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем Form1 (this - текущая форма)
            Formsensor Formsensor = new Formsensor();
            Formsensor.Show(); // отображаем Form2
        }

        private async void Formnewobsl_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Егор\source\repos\myproject\myproject\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionstring);
            await sqlConnection.OpenAsync();
        }

        private async void materialLabel2_Click(object sender, EventArgs e)
        {
            SqlCommand commamd = new SqlCommand("INSERT INTO [medical examination] (patient name, patient surname,date)Values(@patient name,@patientsurname,@date)",sqlConnection);
            commamd.Parameters.AddWithValue("patient name", txtPatientname);
            commamd.Parameters.AddWithValue("patient surname", txtPatientsurname);
            commamd.Parameters.AddWithValue("date", txtDate);
            await commamd.ExecuteNonQueryAsync();
        }

        private void materialCheckbox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
