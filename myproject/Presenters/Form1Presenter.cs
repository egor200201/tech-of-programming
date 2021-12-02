using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myproject.Views;
using myproject.Models;
using myproject.Presenters;

namespace myproject.Presenters
{
   public  class Form1Presenter
    {
        IForm1 Form1view;
        public  Form1Presenter(IForm1 view)
        {
            Form1view = view;
        }
        public void Fullname()
        {
            Form1Model form1 = new Form1Model();
            form1.FirstnameText = Form1view.FirstnameText;
            form1.LastnameText = Form1view.LastnameText;
            Form1view.FullnameText = form1.Fullname1();
        }
    }
}
