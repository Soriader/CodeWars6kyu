using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class DiamondTask
    {
        public static string Pattern(int n)
        {
            List<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string nums = string.Concat(Enumerable.Range(1, i).Select(x => (x % 10).ToString()));
                list.Add(spaces + nums + string.Concat(nums.Substring(0, i - 1).Reverse()) + spaces);
            }

            list.AddRange(list.Take(n - 1).Reverse().ToList());

            return string.Join("\n", list);
        }
        //https://www.codewars.com/kata/5579e6a5256bac65e4000060/train/csharp


        //My first idea but this code couldn't returned correct answer when n > 20. When I started recoded the lines i create a correct code

        //public static string Pattern(int n)
        //{
        //    if(n <= 0)
        //    {
        //        return "";
        //    }

        //    string leftForUp = "1";

        //    if(n == 1)
        //    {
        //        return leftForUp;
        //    }

        //    string up = "";
        //    string rightForUp = "";
        //    string rightBoxForUp = "";

        //    string down = "";
        //    string leftForDown = "";
        //    string rightBoxForDown = "";
        //    string leftBoxForDown = "";
        //    string rightForDown = "";

        //    int iterator = 1;


        //    for (int i = 1; i <= n; i++) 
        //    {
        //        up += String.Concat(Enumerable.Repeat(" ", n - leftForUp.Length)) + leftForUp + rightBoxForUp + String.Concat(Enumerable.Repeat(" ", n - leftForUp.Length)) +"\n";

        //        rightForUp += iterator;
        //        rightBoxForUp = new string(rightForUp.ToString().Reverse().ToArray());
        //        iterator++;
        //        if(iterator == 10)
        //        {
        //            iterator = 0;
        //        }

        //        leftForUp += iterator.ToString();

        //        if (i == n - 2)
        //        {
        //            leftForDown = leftForUp; 
        //            rightForDown = rightBoxForUp; 
        //            down += " " + leftForUp + rightBoxForUp + " " + '\n';
        //        }

        //    }

        //    int space = 2;

        //    for (iterator = n - 1; iterator >= 0; iterator--)
        //    {
        //        rightBoxForDown = rightForDown.Replace((iterator - 1).ToString(), "");

        //        leftBoxForDown = leftForDown.Replace(iterator.ToString(), "");

        //        down += String.Concat(Enumerable.Repeat(" ", space)) + leftBoxForDown + rightBoxForDown + String.Concat(Enumerable.Repeat(" ", space)) + "\n";
        //        space++;

        //        rightForDown = rightBoxForDown;
        //        leftForDown = leftBoxForDown;

        //        if (leftForDown == "1")
        //        {
        //            break;
        //        }
        //    }

        //    return $"{up}{down.TrimEnd('\n')}";
        //}
    }
}
