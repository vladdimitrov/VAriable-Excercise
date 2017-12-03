using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CalculateDpwnWebSite
    {
        static void Main(string[] args)
        {
            int now = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            decimal totalLoss=0.0M;
           

            for (int i =0; i < now; i++)
            {
                
                string[] website = Console.ReadLine().Split().ToArray();
                string siteName = website[0];
                decimal siteVisit = decimal.Parse(website[1]);
                decimal commercialPriceforVisit = decimal.Parse(website[2]);
                decimal siteLoss = siteVisit * commercialPriceforVisit;
                totalLoss = siteLoss+ totalLoss;
                Console.WriteLine(siteName);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(key,now)}");
        }
    }
}
