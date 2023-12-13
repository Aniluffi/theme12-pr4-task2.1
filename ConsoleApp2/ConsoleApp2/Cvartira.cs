using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cvartira
    {
        int number;
        int coast;
        int s;

        public int S 
        {
            set { if (value < 0) Console.WriteLine("Площадь не может быть меньше 0");
                else s = value;
            } 
            get { return s; }
        }

        public int Coast 
        {
            get
            {
                return coast;
            }
            set
            {
                    if (value < 0) Console.WriteLine("Цена не может быть меньше 0");
                    else coast = value;
            }
        }

        public Cvartira ()
        {

        }

        public Cvartira(int number,int coast,int s)
        {
            this.S = s;
            this.number = number;
            this.Coast = coast;
        }

        public void Inf ()
        {
            Console.WriteLine($"Информация о квартире:\n" +
                $"Номер - {number}\n" +
                $"Цена за 1 кв - {coast}\n" +
                $"S - {s}\n");
        }

        public void CoastKv() 
        {
            Console.WriteLine(s*coast);
        }
    }
}
