using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat x;
            x = new Trojkat(2, 1, 2.5);// new do tworzenia nowych obiektów
            Console.WriteLine(x);
            Console.WriteLine(x.Obwod() ); // funkcja Obwód
            Console.WriteLine(x.Obwód); // properties get Obwód
            //x.C = 4;
            Console.WriteLine(x.Obwód);
            Console.WriteLine(x.Pole);

            var y = new Trojkat(); //deklaracja z przypisaniem
            Console.WriteLine(y);
            
        }         
    }





}
