using System;

namespace _11_PriceChangeAlert
{

    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double contrast = Percentage(lastPrice, currentPrice);
                bool isSignificantDifference = CheckForDifference(contrast, treshold);
                string message = Get(currentPrice, lastPrice, contrast, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string Get(double currentPrice, double last, double contrast, bool eitherTrueOrFalse)

        {
            string result = String.Empty;

            if (contrast == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!eitherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currentPrice, contrast * 100);
            }
            else if (eitherTrueOrFalse && (contrast > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currentPrice, contrast * 100);
            }
            else if (eitherTrueOrFalse && (contrast < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currentPrice, contrast * 100);

            return result;
        }
        private static bool CheckForDifference(double treshold, double price)
        {
            if (Math.Abs(treshold) >= price)
            {
                return true;
            }
            return false;
        }

        private static double Percentage(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
