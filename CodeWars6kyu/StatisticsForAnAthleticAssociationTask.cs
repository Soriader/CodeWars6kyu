using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class StatisticsForAnAthleticAssociationTask
    {
        public static string Stat(string strg)
        {
            if(strg == "")
            {
                return "";
            }
            var records = strg.Replace(" ", "").Replace('|', ':').Split(",").Select(x => TimeSpan.Parse(x)).OrderBy(x => x).ToList();

            TimeSpan mediana;
            var half = records.Count / 2;

            if (records.Count % 2 == 0) 
            { 
                var average = (records[half - 1 ].Ticks + records[half].Ticks)/2;
                mediana = TimeSpan.FromTicks(average);
            }
            else
            {
                mediana = records[half];
            }



            return $"Range: {(records.Max() - records.Min()).ToString(@"hh\|mm\|ss")} Average: {TimeSpan.FromTicks(records.Select(x => x.Ticks).Sum() / records.Count()).ToString(@"hh\|mm\|ss")} Median: {mediana.ToString(@"hh\|mm\|ss")}";


        }
    }
}
//https://www.codewars.com/kata/55b3425df71c1201a800009c/train/csharp