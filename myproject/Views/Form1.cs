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
    public partial class Form1 : MaterialForm
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
     //   public string ResultText { get => txtResult.Text; set => txtResult.Text = value; }

        private void materialButton2_Click(object sender, EventArgs e)
        {
           

            if (form1mistake.Visible)
                form1mistake.Visible = false;

            if (!string.IsNullOrEmpty(txtFirstname.Text) && !string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                this.Hide(); // скрываем Form1 (this - текущая форма)
                Formadmin Formadmin = new Formadmin();
                Formadmin.Show(); // отображаем Form2
            }
            else
            {
                form1mistake.Visible = true;

                form1mistake.Text = "check data!";
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (form1mistake.Visible)
                form1mistake.Visible = false;

            if (!string.IsNullOrEmpty(txtFirstname.Text) && !string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                this.Hide(); // скрываем Form1 (this - текущая форма)
                Formnewobsl Formnewobsl = new Formnewobsl();
                Formnewobsl.Show(); // отображаем Form2
            }
            else
            {
                form1mistake.Visible = true;

                form1mistake.Text = "check data!";
            }
        }
    }
    }

     
      
