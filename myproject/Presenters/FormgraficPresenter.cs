using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myproject.Views;
using myproject.Models;

namespace myproject.Presenters
{
    public class FormgraficPresenter
    {
        IFormgrafic Formgraficview;
        public FormgraficPresenter(IFormgrafic view)
        {
            Formgraficview = view; 
        }
        public void Skintemp(int typeofact, int tempsensor)
        {
            FormgraficModel formgrafic = new FormgraficModel();
            Formgraficview.value = formgrafic.Skintemp1(typeofact,tempsensor);
        }
        public void Elconductivity(int typeofact, int elsensor)
        {
            FormgraficModel formgrafic = new FormgraficModel();
            Formgraficview.value1 = formgrafic.Electricalconductivity1(typeofact, elsensor);
        }

        public void Bloodpresure(int typeofact, int pressensor)
        {
            FormgraficModel formgrafic = new FormgraficModel();
            Formgraficview.value2 = formgrafic.Bloodpresure1(typeofact, pressensor);
        }
      
        public void Skinmoisture(int typeofact, int moistsensor)
        {
            FormgraficModel formgrafic = new FormgraficModel();
            Formgraficview.value3 = formgrafic.Skinmoisture1(typeofact, moistsensor);
        }
        public void Hartrate(int typeofact, int ratesensor)
        {
            FormgraficModel formgrafic = new FormgraficModel();
            Formgraficview.value4 = formgrafic.Hartrate1(typeofact, ratesensor);
        }
    }
}