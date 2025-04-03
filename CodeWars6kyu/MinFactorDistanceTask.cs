namespace CodeWars6kyu;

public class MinFactorDistanceTask
{
    public static int MinDistance(int n)
    {
        var allDivisors = AllDivisors(n);
        var results = new List<int>();

        for (int i = 0; i < allDivisors.Count - 1; i++)
        {
            results.Add(Math.Abs(allDivisors[i] - allDivisors[i + 1]));
        }

        return results.Min();
    }


    private static List<int> AllDivisors(int number)
    {
        var allDivisors = new List<int>();

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                allDivisors.Add(i);
            }
        }
        
        return allDivisors.OrderBy(x => x).ToList();
    }
}
//https://www.codewars.com/kata/59b8614a5227dd64dc000008/train/csharp