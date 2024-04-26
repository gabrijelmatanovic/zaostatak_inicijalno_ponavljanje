using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01022024_2
{
    class Brojevi
    {
        double broj;
        public double Broj { get => broj; set => broj = value; }
        public virtual double ApsVrijednost()
        {
            return 0;
        }
    }

    class Cijeli : Brojevi
    {
        public override double ApsVrijednost()
        {
            if (Broj >= 0)
            {
                return Broj;
            }
            else
            {
                return -Broj;
            }
        }
    }
    class Decimalni : Brojevi
    {
        public override double ApsVrijednost()
        {
            if (Broj >= 0)
            {
                return Broj;
            }
            else
            {
                return -Broj;
            }
        }
    }
    class Pozitivni : Cijeli { }
    class Negativni : Cijeli { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            x.Broj = 100;
            Console.WriteLine("Apsolutna vrijednost x: " + x.ApsVrijednost());

            Negativni y = new Negativni();
            y.Broj = -100;
            Console.WriteLine("Apsolutna vrijednost y: " + y.ApsVrijednost());

            Decimalni z = new Decimalni();
            z.Broj = 100.45;
            Console.WriteLine("Apsolutna vrijednost z: " + z.ApsVrijednost());

            Console.ReadKey();
        }
    }
}