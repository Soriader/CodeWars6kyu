namespace CodeWars6kyu;

public class HelpKiyoSolveHerProblemsLCMFunTask
{
    public static long KiyoLCM(Object[][] a)
    {
        if (a == null || a.Length == 0)
            return 0;

        var sums = new List<long>();

        foreach (var subArray in a)
        {
            if (subArray == null)
            {
                sums.Add(0);
                continue;
            }

            long sum = 0;
            
            foreach (var item in subArray)
            {
                if (item is int num && num % 2 != 0)
                {
                    sum += num;
                }
            }

            sums.Add(sum);
        }

        if (sums.All(s => s == 0))
        {
            return 0;
        }

        return LCMArray(sums);
    }

    private static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    private static long LCM(long a, long b)
    {
        if (a == 0 || b == 0)
        {
            return 0;
        }
        
        return Math.Abs(a * b) / GCD(a, b);
    }

    private static long LCMArray(List<long> numbers)
    {
        return numbers.Aggregate(1L, (current, num) => LCM(current, num));
    }
}

//https://www.codewars.com/kata/5872bb7faa04282110000124/train/csharp