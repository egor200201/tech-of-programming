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
        public double Skintemp1(int typeofact, int tempsensor)
        {
            double randTemp;
            double plusminus;

            if (typeofact == 1)
            {
                randTemp = 36.8;
                Random rnd = new Random();
                plusminus = rnd.Next(-1, 1);
                plusminus = plusminus / 10;
                //Random randomTemperature = new Random();
                //randTemp = randomTemperature.Next(35, 42);
                randTemp = randTemp + plusminus;
            }
            if (typeofact == 2)
            {
                randTemp = 36.6;
                Random rnd = new Random();
                plusminus = rnd.Next(-1, 1);
                plusminus = plusminus / 10;
                //Random randomTemperature = new Random();
                //randTemp = randomTemperature.Next(34, 42);
                //randTemp = Convert.ToInt32(randTemp * 1.2);
                randTemp = randTemp + plusminus;
            }
            else
            {
                randTemp = 36.7;
                Random rnd = new Random();
                plusminus = rnd.Next(-1, 1);
                plusminus = plusminus / 10;
                //Random rnd = new Random();
                //randTemp = Math.Round(36.6 + rnd.NextDouble() * (35 + 37.2), 13);
                //randTemp = randTemp * 1.1;
                //Random randomTemperature = new Random();
                //randTemp = randomTemperature.Next(34, 42);
                //randTemp = Convert.ToInt32(randTemp * 0.8);
                randTemp = randTemp + plusminus;
            }
            if (tempsensor == 1)
            { return randTemp; }
            else { return 36; }
        }





        public static int el=0;

        public int Electricalconductivity1(int typeofact, int elsensor)
        {

            int randEl;
            Thread.Sleep(15);
            if (typeofact == 1)
            {
                if (el < 25)
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(0, 1);
                    el = el + randEl;
                }
                else
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(-1, 1);
                    el = el + randEl;
                }
            }
            if (typeofact == 2)
            {

                if (el < 20)
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(0, 3);
                    el = el + randEl;
                }
                else
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(-1, 1);
                    el = el + randEl;
                }
            }
            else
            {

                if (el < 23)
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(0, 2);
                    el = el + randEl;
                }
                else
                {
                    Random randomEl = new Random();
                    randEl = randomEl.Next(-1, 1);
                    el = el + randEl;

                }
            }
            if (elsensor == 1)
            { return el; }
            else { return 10; }
        }



        //   Random rnd = new Random();
        // operand = rnd.Next(0, 5);
        //return operand;


        public static int pres=110;
        public int Bloodpresure1(int typeofact,int pressensor)
        {
            int randPres;
            if (pressensor == 1)
            {
                Thread.Sleep(15);

                if (typeofact == 1)
                {
                    if (pres < 150)
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(0, 5);
                        pres = pres + randPres;
                    }
                    else
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(-1, 1);
                        pres = pres + randPres;

                    }
                }
                
                if (typeofact == 2)
                {
                    if (pres < 130)
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(0, 4);
                        pres = pres + randPres;
                    }
                    else
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(-1, 1);
                        pres = pres + randPres;

                    }

                }
                else
                {
                    if (pres < 140)
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(0, 5);
                        pres = pres + randPres;
                    }
                    else
                    {
                        Random randomPresure = new Random();
                        randPres = randomPresure.Next(-1, 1);
                        pres = pres + randPres;

                    }
                }
            }
            else { pres = 100; }
            return pres;

        }
        public static int moist=15;
        public int Skinmoisture1(int typeofact,int moistsensor)
        {
            Thread.Sleep(15);
            int randMoist;
            
                if (typeofact == 1)
                {
                if (moist < 25)
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(0, 3);
                    moist = moist + randMoist;
                }
                else
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(-1, 1);
                    moist = moist + randMoist;

                }
            }
                if (typeofact == 2)
                {

                if (moist < 25)
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(0, 1);
                    moist = moist + randMoist;
                }
                else
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(-1, 1);
                    moist = moist + randMoist;

                }
            }
                else
                {

                if (moist < 25)
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(0, 2);
                    moist = moist + randMoist;
                }
                else
                {
                    Random randomMoist = new Random();
                    randMoist = randomMoist.Next(-1, 1);
                    moist = moist + randMoist;

                }
            }
            if (moistsensor == 1)
            {
                return moist;
            }
            else
            { return 15; }
         

        }
        public static int Rate=60;
        public int Hartrate1(int typeofact,int ratesensor)
        {
            
            Thread.Sleep(15);
           
                if (typeofact == 1)
                {

                    Random randomRate = new Random();
                if (Rate < 160)
                {
                    randRate = randomRate.Next(0, 5);
                    Rate = Rate + randRate;
                }
                else
                {
                    randRate = randomRate.Next(-1, 1);

                    Rate = Rate + randRate;
                }


                
            }
            if (typeofact == 2)
                {
                Random randomRate = new Random();
                if (Rate < 130)
                {
                    randRate = randomRate.Next(0, 3);
                    Rate = Rate + randRate;
                }
                else
                {
                    randRate = randomRate.Next(-1, 1);

                    Rate = Rate + randRate;
                }
            }
            if (typeofact == 3)
            {
                Random randomRate = new Random();
                if (Rate < 145)
                {
                    randRate = randomRate.Next(0, 4);
                    Rate = Rate + randRate;
                }
                else
                {
                    randRate = randomRate.Next(-1, 1);

                    Rate = Rate + randRate;
                }
            }
            if (ratesensor == 1)
            {
                return Rate;
            }
            else { return 60; }
          
            
        }
           

        }


    }

