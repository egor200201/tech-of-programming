using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myproject.Views;
using myproject.Models;

namespace myproject.Presenters
{
    public class FormsensorPresenter
    {
        IFormsensor Formsensorview;
        public FormsensorPresenter(IFormsensor view)
        {
            Formsensorview = view;
        }
        public void SendResult()
        {
            FormsensorModel formsensor = new FormsensorModel();
            Formsensorview.value= formsensor.SendResult1();
        }
    }
}
