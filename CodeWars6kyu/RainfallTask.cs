using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class RainfallTask
    {
        public static Dictionary<string, List<double>> ParseData(string strng)
        {
            var data = new Dictionary<string, List<double>>();

            foreach (var line in strng.Split('\n'))
            {
                var parts = line.Split(':');
                var city = parts[0];
                var rainfalls = parts[1].Split(',')
                                        .Select(r => double.Parse(r.Split(' ')[1], System.Globalization.CultureInfo.InvariantCulture))
                                        .ToList();
                data[city] = rainfalls;
            }

            return data;
        }

        public static double Mean(string town, string strng)
        {
            var data = ParseData(strng);

            if (!data.ContainsKey(town))
                return -1;

            var rainfalls = data[town];
            return rainfalls.Average();
        }

        public static double Variance(string town, string strng)
        {
            var data = ParseData(strng);

            if (!data.ContainsKey(town))
                return -1;

            var rainfalls = data[town];
            double mean = rainfalls.Average();
            return rainfalls.Select(r => (r - mean) * (r - mean)).Average();
        }
    }
}
//https://www.codewars.com/kata/56a32dd6e4f4748cc3000006/train/csharp