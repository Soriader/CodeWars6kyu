namespace CodeWars6kyu;

public class FindTheOrderBreakerTask
{
    public static int OrderBreaker(int[] input)
    {
        if (input.Length >= 2 && input[0] > input[1])
        {
            return input[0];
        }

        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] > input[i + 1])
            {
                if (input[i - 1] < input[i + 1])
                {
                    return input[i];
                }
                else
                {
                    return input[i + 1];
                }
            }
        }

        if (input.Length >= 2 && input[input.Length - 2] > input[input.Length - 1])
        {
            return input[input.Length - 1];
        }

        return 0;
    }
}
//https://www.codewars.com/kata/5fc2a4b9bb2de30012c49609/train/csharp