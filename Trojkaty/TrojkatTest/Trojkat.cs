using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Trojkat
    {
        // FIELDS
        private decimal a;
        public double A
        {
            get { return (double)a; } // pobrane (double)
            set                       // zmodyfikowane (void) is - czy jest? (bool)
            {
                if (!jestWarunekTrojkata((decimal)value, b, c))
                    throw new ArgumentException("nie można zmienić boku A");

                a = (decimal)value;
            }

        }
        private decimal b;
        public double B
        {
            get => (double)b; // taki sam zapis jak w przypadku a
            set {
                if (!jestWarunekTrojkata(a, (decimal)value, c))
                    throw new ArgumentException("nie można zmienić boku A");

                b = (decimal)value;
            }
        }

        //public decimal C {get; set;} tak się robi properties automatyczne, ale tutaj nie da się ich użyć
        private decimal c;
        public double C
        {
            get => (double)c;
            set {
                if (!jestWarunekTrojkata(a, b, (decimal)value))
                    throw new ArgumentException("nie można zmienić boku A");

                c = (decimal)value;
            }
        }

        private bool jestWarunekTrojkata(decimal x, decimal y, decimal z)
        {
            return x + y > z && x + z > y && y + z > x;

        }

        // KONSTRUKTORY
        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Argument musi być dodatni");

            if (!jestWarunekTrojkata ((decimal)a, (decimal)b, (decimal)c))
                // ab+b<=c || a+c<=b || b+c<=a zamiast wykrzyknika odwrotność tego co na górze
                throw new ArgumentException("Nie spełniony warunek trójkąta");


            this.a = (decimal)a;
            this.b = (decimal)b;
            this.c = (decimal)c;
        }

        public Trojkat()
        {
            a = b = c = 1;
        }

        // PRZECIĄŻENIE ToString
        public override string ToString() // zmiana sposobu tekstowego patrzenia na nasz obiekt (z domyślnego)
        {
            return $"Trojkat: a={a} b={b} c={c}";
        }

        public double Obwod()
        {
            return (double)(a + b + c);
        }

        public double Obwód
        {
            get { return (double)(a + b + c); }
        }

        public double Pole
        {
            get
            {
                decimal p = (decimal)(0.5 * Obwód);
                return Math.Sqrt( (double)(p * (p - a) * (p - b) * (p - c)) ); // sqrt -> pierwiasek kwadratowy

            }

        }

        bool jestProstokatny // z twierdzenia pitagorasa true or false (double) bo dec byłby niedokładny
        {
            get
            {
                throw new NotImplementedException();
            }

        }
        
        // rozwartokątny a^2 + b^2 < c^2

    }
}
