using System;
using System.Collections.Generic;

namespace ShippingPackages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OvernightPackage overnight1 = new OvernightPackage("yomi", "kenny", "11road Fetac Lagos", "km 12 austin house House", 5.2m, 80);
            Console.WriteLine(overnight1);
            Console.WriteLine($"{overnight1.CalculateCost():C}");
           
            OvernightPackage overnight2 = new OvernightPackage("seun", "mike","21 road Aguda Surulere", "Green Avenue Ogun State", 3.2m, 120);
            Console.WriteLine(overnight2);
            Console.WriteLine($"{overnight2.CalculateCost():C}");
           
            TwoDayPackage twoDayPackage = new TwoDayPackage("Sahun", "Terry Get", "31th avenue Yarn State Road", "23 road C close festac Town", 3.2m, 120);
            
            Console.WriteLine(twoDayPackage);
            Console.WriteLine($"{twoDayPackage.CalculateCost():C}");

            TwoDayPackage twoDayPackage1 = new TwoDayPackage("Travis Green", "Dom Noen", "11 Esstienal Estate Clean State Road", "24 Mile Opp Housing Block Avenue", 2.2m, 40);

            Console.WriteLine(twoDayPackage1);
            Console.WriteLine($"{twoDayPackage1.CalculateCost():C}");

            Console.WriteLine("==========Looping through Packages polymorphically============");

            List<Package> packages = new List<Package> { overnight1,overnight2,twoDayPackage,twoDayPackage1};

            decimal totalShippingCost = 0.0M; int count = 1;
            foreach(var package in packages)
            {
                Console.WriteLine(package.ToString());
                Console.WriteLine($"Package {count} is : {package.CalculateCost():C}");
                totalShippingCost += package.CalculateCost();
                count++;
            }

            Console.WriteLine($"Total Shipping Cost For All Packages : { totalShippingCost:C}");




        }
    }
}
