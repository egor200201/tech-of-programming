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
using myproject.Views;
using myproject.Presenters;
namespace myproject
{
    public partial class Formsensor : MaterialForm, IFormsensor
    {
        int value1;

        public Formsensor()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        int IFormsensor.value 
        {
            get 
            {
                return value1;
            }
            set 
            {
                value1 = value;
            } 
        }

        private void Formsensor_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем Form1 (this - текущая форма)
            Formgrafic Formgrafic = new Formgrafic();
            Formgrafic.Show(); // отображаем Form2
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (sensor.Visible)
                sensor.Visible = false;

            FormsensorPresenter presenter = new FormsensorPresenter(this);
            presenter.SendResult();
            if (value1!=1)
            {
                sensor.Visible = true;

                sensor.Text = "all sensors working!";
            }
            else
            {
                sensor.Visible = true;

                sensor.Text = "something went wrong try again";
            }
        }
    }
    }

