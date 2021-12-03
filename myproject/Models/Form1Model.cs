using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Models
{
    public class Form1Model
    {
        public string FirstnameText { get; set; }
        public string LastnameText { get; set; }

        public string SendResult1()
        {
            return FirstnameText +" " + LastnameText +" loged";

        }
    }
}