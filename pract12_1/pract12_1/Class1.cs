using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract12_1
{
    class Student
    {
        public string name;
        public int rost;
        private int ves=50;
        public double SetEat(int eda)
        {
            if(eda>0)
            {
            if (eda > 5 && eda < 10)
            {
                rost=rost - 1; 
                ves += (eda * 1000 - 1600);
            }
            else if (eda > 10) 
            {
                rost = rost - 2;
                ves += (eda * 1000 - 1800);

            }
            else
            {
                ves = ves - 2;
            }


            }
            else
            {
                ves = 0;
                rost = 0;
            }

            return ves;
            
        }
        public double SetRost(int eda)
        {
            if (eda > 0)
            {
                if (eda > 5 && eda < 10)
                {
                    rost = rost - 1;
                }
                else if (eda > 10)
                {
                    rost = rost - 2;
                }
                else
                {
                    rost= rost - 5;
                }
               
            } 
            else
                {
                 
                    rost = 0;
                }
                return rost;
        }
      
        public double GetEat()
        {
            return ves;
        }


    }
}
