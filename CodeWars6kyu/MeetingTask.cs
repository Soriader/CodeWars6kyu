using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class MeetingTask
    {
        public static string Meeting(string s)
        {
            var names = s.ToUpper().Split(';')
            .Select(n => n.Split(':'))
            .Select(n => (FirstName: n[0], LastName: n[1]))
            .ToList();

            var sortedNames = names
                .OrderBy(n => n.LastName)
                .ThenBy(n => n.FirstName)
                .Select(n => $"({n.LastName}, {n.FirstName})");

            return string.Join("", sortedNames);
        }
    }
}
//https://www.codewars.com/kata/59df2f8f08c6cec835000012/train/csharp