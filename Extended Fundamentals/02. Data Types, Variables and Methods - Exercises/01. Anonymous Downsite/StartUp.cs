namespace _01.Anonymous_Downsite
{
    using System;
    using System.Numerics;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int sitesDownCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0.0m;

            for (int i = 0; i < sitesDownCount; i++)
            {
                var websiteData = Console.ReadLine().Split().ToArray();

                string siteName = websiteData[0];
                decimal siteVisits = decimal.Parse(websiteData[1]);
                decimal pricePerVisit = decimal.Parse(websiteData[2]);

                decimal siteLoss = siteVisits * pricePerVisit;
                totalLoss += siteLoss;

                Console.WriteLine(siteName);
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, sitesDownCount);

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
