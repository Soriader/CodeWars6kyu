namespace CodeWars6kyu;

public class DominantPrimesTask
{
    public static int Solve(int a, int b)
    {
        List<int> primes = GeneratePrimesUpTo(b);
        List<int> dominantPrimes = new List<int>();

        int position = 1;
        foreach (int prime in primes)
        {
            if (prime >= a && prime <= b)
            {
                if (IsPrime(position))
                {
                    dominantPrimes.Add(prime);
                }
            }
            position++;
        }

        return dominantPrimes.Sum();
    }

    static List<int> GeneratePrimesUpTo(int limit)
    {
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i]) primes.Add(i);
        }

        return primes;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n == 2)
        {
            return true;
        }
        if (n % 2 == 0)
        {
            return false;
        }

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
//https://www.codewars.com/kata/59ce11ea9f0cbc8a390000ed/train/csharp