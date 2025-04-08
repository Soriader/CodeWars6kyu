using System.Numerics;

namespace CodeWars6kyu;

public class PathsInTheGridTask
{
    public static BigInteger NumberOfRoutes(int m, int n)
    {
        int smaller = Math.Min(m, n);
        int total = m + n;
        
        BigInteger result = 1;
        
        for (int i = 1; i <= smaller; i++)
        {
            result = result * (total - smaller + i) / i;
        }
        
        return result;        
    }
}
//https://www.codewars.com/kata/56a127b14d9687bba200004d/train/csharp
