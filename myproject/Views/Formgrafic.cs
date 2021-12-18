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
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using myproject.Views;
using myproject.Presenters;
namespace myproject
{
    public partial class Formgrafic : MaterialForm, IFormgrafic
    {
        double temp;
        int elconductivity;
        int bloodpresure;
        int skinmoisture;
        int hartrate;
        public int typeofact;
        public int pressensor;
        public int ratesensor;
        public int elsensor;
        public int moistsensor;
        public int tempsensor;
        public Formgrafic()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        double IFormgrafic.value
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }
        int IFormgrafic.value1
        {
            get
            {
                return elconductivity;
            }
            set
            {
                elconductivity = value;
            }
        }
        int IFormgrafic.value2
        {
            get
            {
                return bloodpresure;
            }
            set
            {
                bloodpresure = value;
            }
        }
        int IFormgrafic.value3
        {
            get
            {
                return skinmoisture;
            }
            set
            {
                skinmoisture = value;
            }
        }
        int IFormgrafic.value4
        {
            get
            {
                return hartrate;
            }
            set
            {
                hartrate = value;
            }
        }
        private int _countseconds = 0;

        private void Formgrafic_Load(object sender, EventArgs e)
        {   typeofact= Formnewobsl.typeofact1;
            pressensor = Formnewobsl.pressensor1;
            ratesensor = Formnewobsl.ratesensor1;
            elsensor = Formnewobsl.elsensor1;
            tempsensor = Formnewobsl.tempsensor1;
            moistsensor = Formnewobsl.moistsensor1;
            timer.Enabled = true;
            chart.ChartAreas[0].AxisY.Maximum = 38;
            chart.ChartAreas[0].AxisY.Minimum = 36;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart.Series[0].XValueType = ChartValueType.DateTime;
            chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart.ChartAreas[0].AxisX.Interval = 5;

            electricalconductivitychart.ChartAreas[0].AxisY.Maximum = 30;
            electricalconductivitychart.ChartAreas[0].AxisY.Minimum = 0;
            electricalconductivitychart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            electricalconductivitychart.Series[0].XValueType = ChartValueType.DateTime;
            electricalconductivitychart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            electricalconductivitychart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            electricalconductivitychart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            electricalconductivitychart.ChartAreas[0].AxisX.Interval = 5;


            
            bloodpresurechart.ChartAreas[0].AxisY.Maximum = 170;
            bloodpresurechart.ChartAreas[0].AxisY.Minimum = 70;
            bloodpresurechart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            bloodpresurechart.Series[0].XValueType = ChartValueType.DateTime;
            bloodpresurechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            bloodpresurechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            bloodpresurechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            bloodpresurechart.ChartAreas[0].AxisX.Interval = 5;

            skinmoisturechart.ChartAreas[0].AxisY.Maximum = 30;
            skinmoisturechart.ChartAreas[0].AxisY.Minimum = 8;
            skinmoisturechart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            skinmoisturechart.Series[0].XValueType = ChartValueType.DateTime;
            skinmoisturechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            skinmoisturechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            skinmoisturechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            skinmoisturechart.ChartAreas[0].AxisX.Interval = 5;


            hartratechart.ChartAreas[0].AxisY.Maximum = 180;
            hartratechart.ChartAreas[0].AxisY.Minimum = 50;
            hartratechart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            hartratechart.Series[0].XValueType = ChartValueType.DateTime;
            hartratechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            hartratechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            hartratechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            hartratechart.ChartAreas[0].AxisX.Interval = 5;

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем Form1 (this - текущая форма)
            Formnewobsl Formnewobsl = new Formnewobsl();
            Formnewobsl.Show(); // отображаем Form2
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем Form1 (this - текущая форма)
            Form1 Form1 = new Form1();
            Form1.Show(); // отображаем Form2
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  Random randomTemperature = new Random(DateTime.Now.Millisecond);
            // double randTemp = randomTemperature.Next(34, 42);
            FormgraficPresenter presenter = new FormgraficPresenter(this);
            presenter.Skintemp(typeofact,tempsensor);
            DateTime timeNow = DateTime.Now;
            chart.Series[0].Points.AddXY(timeNow, temp);
            presenter.Elconductivity(typeofact,elsensor);
            electricalconductivitychart.Series[0].Points.AddXY(timeNow, elconductivity);
            presenter.Bloodpresure(typeofact,pressensor);
            bloodpresurechart.Series[0].Points.AddXY(timeNow, bloodpresure);
            presenter.Skinmoisture(typeofact,moistsensor);
            skinmoisturechart.Series[0].Points.AddXY(timeNow, skinmoisture);
            presenter.Hartrate(typeofact,ratesensor);
            hartratechart.Series[0].Points.AddXY(timeNow, hartrate);
            _countseconds++;
            if(_countseconds==30)
            {
                _countseconds = 0;
                chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart.ChartAreas[0].AxisX.Interval = 5;

                electricalconductivitychart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                electricalconductivitychart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                electricalconductivitychart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                electricalconductivitychart.ChartAreas[0].AxisX.Interval = 5;

                skinmoisturechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                skinmoisturechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                skinmoisturechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                skinmoisturechart.ChartAreas[0].AxisX.Interval = 5;

                bloodpresurechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                bloodpresurechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                bloodpresurechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                bloodpresurechart.ChartAreas[0].AxisX.Interval = 5;

                hartratechart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                hartratechart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
                hartratechart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                hartratechart.ChartAreas[0].AxisX.Interval = 5;

            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
