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
namespace myproject
{
    public partial class Formnewobsl : MaterialForm
    {
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

        private void Formnewobsl_Load(object sender, EventArgs e)
        {

        }
    }
}
