using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myproject.Models
{
    public class FormgraficModel
    {

        //public int operand;
        public int randTemp;
        public int randEl;
        public int randRate;
        public int randMoist;
        public int randPres;
        public int Skintemp1(int typeofact, int tempsensor)
        {
            int randTemp;

            if (typeofact == 1)
            {
                Random randomTemperature = new Random();
                randTemp = randomTemperature.Next(34, 42);
                randTemp = Convert.ToInt32(randTemp * 1.2);
            }
            if (typeofact == 2)
            {
                Random randomTemperature = new Random();
                randTemp = randomTemperature.Next(34, 42);
                //randTemp = Convert.ToInt32(randTemp * 1.2);
            }
            else
            {
                Random randomTemperature = new Random();
                randTemp = randomTemperature.Next(34, 42);
                randTemp = Convert.ToInt32(randTemp * 0.8);
            }
            if (tempsensor == 1)
            { return randTemp; }
            else { return 36; }
        }







        public int Electricalconductivity1(int typeofact, int elsensor)
        {

            int randEl;
            Thread.Sleep(15);
            if (typeofact == 1)
            {
                Random randomEl = new Random(DateTime.Now.Millisecond);
                randEl = randomEl.Next(32, 44);
                randEl = Convert.ToInt32(randEl * 1.2);
            }
            if (typeofact == 2)
            {
                Random randomEl = new Random(DateTime.Now.Millisecond);
                randEl = randomEl.Next(32, 44);

            }
            else
            {
                Random randomEl = new Random(DateTime.Now.Millisecond);
                randEl = randomEl.Next(32, 44);
                //  randEl = 36;
                randEl = Convert.ToInt32(randEl * 0.8);
            }
            if (elsensor == 1)
            { return randEl; }
            else { return 36; }
        }
        
        
            
            //   Random rnd = new Random();
            // operand = rnd.Next(0, 5);
            //return operand;

        
       
        public int Bloodpresure1(int typeofact,int pressensor)
        {
            int randPres;
            if (pressensor == 1)
            {
                Thread.Sleep(15);
                if (typeofact == 1)
                {
                    Random randomPresure = new Random();
                    randPres = randomPresure.Next(34, 42);
                    randPres = Convert.ToInt32(randPres * 1.2);
                }
                if (typeofact == 2)
                {
                    Random randomPresure = new Random();
                    randPres = randomPresure.Next(34, 42);

                }
                else
                {
                    Random randomPresure = new Random();
                    randPres = randomPresure.Next(34, 42);
                    randPres = Convert.ToInt32(randPres * 0.8);
                }
            }
            else { randPres = 36; }
            return randPres;

        }
        public int Skinmoisture1(int typeofact,int moistsensor)
        {
            Thread.Sleep(15);
            int randMoist;
            
                if (typeofact == 1)
                {

                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(34, 42);
                    randMoist = Convert.ToInt32(randMoist * 1.2);
                }
                if (typeofact == 2)
                {

                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(34, 42);

                }
                else
                {

                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(34, 42);
                    randMoist = Convert.ToInt32(randMoist * 0.8);
                }
            if (moistsensor == 1)
            {
                return randMoist;
            }
            else
            { return 36; }
         

        }
        public int Hartrate1(int typeofact,int ratesensor)
        {
            int randRate;
            Thread.Sleep(15);
           
                if (typeofact == 1)
                {

                    Random randomRate = new Random();

                    randRate = randomRate.Next(34, 42);
                randRate = Convert.ToInt32(randRate * 1.2);
            }
            if (typeofact == 2)
                {
                    Random randomRate = new Random();

                    randRate = randomRate.Next(34, 42);
                }
                else
                {
                    Random randomRate = new Random();

                    randRate = randomRate.Next(34, 42);
                    randRate = Convert.ToInt32(randRate * 0.8);
            }
            if (ratesensor == 1)
            {
                return randRate;
            }
            else { return 36; }
          
            
        }
           

        }


    }

