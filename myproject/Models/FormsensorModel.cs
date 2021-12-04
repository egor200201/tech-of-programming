using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.Models
{
        public  class FormsensorModel
    {

        public int operand;
        public int SendResult1()
        {

            Random rnd = new Random();    
            operand = rnd.Next(0, 5);
            return operand;

        }
    }
}
