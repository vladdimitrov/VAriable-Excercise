using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            decimal M1000 = decimal.Parse(Console.ReadLine());

            int P = int.Parse(Console.ReadLine());
            int restS = 5;
            int wflapsS = 100;
            int time = N / wflapsS;
            int rest = N / P * 5;
            int allTime = time + rest;

            decimal distance = N * M1000/1000;


            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{allTime} s.");



        }
    }
}
