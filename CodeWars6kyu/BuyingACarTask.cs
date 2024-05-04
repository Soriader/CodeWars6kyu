using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BuyingACarTask
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            double priceOld = startPriceOld;
            double priceNew = startPriceNew;
            int saving = 0;
            double currentPercentLoss = percentLossByMonth;
            int month = 0;

            while (priceOld + saving < priceNew)
            {
                ++month;
                if (month % 2 == 0)
                {
                    currentPercentLoss += 0.5;
                }

                priceOld *= 1 - currentPercentLoss / 100;
                priceNew *= 1 - currentPercentLoss / 100;
                saving += savingPerMonth;
            }

            return new int[] { month, (int)Math.Round(priceOld + saving - priceNew) };

        }
    }
}
//https://www.codewars.com/kata/554a44516729e4d80b000012/train/csharp