using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using myproject.Models;
using myproject.Views;
using myproject.Presenters;
namespace myproject
{
    public partial class Form1 : MaterialForm, IForm1
    {
      

        public Form1()
        {





            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);





        }

       

        public string FirstnameText { get => txtFirstname.Text; set => txtFirstname.Text = value; }
        public string LastnameText { get => txtLastname.Text; set => txtLastname.Text = value; }
        public string FullnameText { get => txtFullname.Text; set => txtFullname.Text = value; }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //  this.Hide(); // скрываем Form1 (this - текущая форма)
            // Formadmin Formadmin = new Formadmin();
            //Formadmin.Show(); // отображаем Form2
            Form1Presenter presenter = new Form1Presenter(this);
            presenter.Fullname();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


            this.Hide(); // скрываем Form1 (this - текущая форма)
            Formnewobsl Formnewobsl = new Formnewobsl();
            Formnewobsl.Show(); // отображаем Form2

        }

        
    } 
}