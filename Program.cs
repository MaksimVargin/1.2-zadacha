using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, P, Q; //R-радиус шара, P-первая диагональ ромба, Q-вторая диагональ ромба
            Console.Write("R = ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("P = ");
            P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Q = ");
            Q = Convert.ToDouble(Console.ReadLine());
            if (R<=Math.Sqrt(P*P+Q*Q)/4) //Сторона ромба равна половине радиуса, если шар соприкасается со сторонами ромба
                Console.WriteLine("Шар может пройти через ромбообразное отверстие");
            else
                Console.WriteLine("Шар не может пройти через ромбообразное отверстие");
            Console.ReadKey();
        }
    }
}
