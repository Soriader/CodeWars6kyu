namespace CodeWars6kyu;

public class AmidakujiTask
{
    public static int[] Amidakuji(string[] ar)
    {
        if (ar == null || ar.Length == 0)
        {
            return Array.Empty<int>();
        }
        
        int width = ar[0].Length;
        int height = ar.Length;
        
        int[] result = new int[width + 1];
        for (int i = 0; i <= width; i++)
        {
            result[i] = i;
        }

        foreach (string level in ar)
        {
            for (int i = 0; i < level.Length; i++)
            {
                if (level[i] == '1')
                {
                    if (i + 1 < result.Length)
                    {
                        int temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                    }
                }
            }
        }

        return result;
    }
}
//https://www.codewars.com/kata/5af4119888214326b4000019/train/csharp