namespace CodeWars6kyu;

public class CompleteThePatternPlusTask
{
    public static string Pattern(int n)
    {
        if (n < 1)
        {
            return "";
        }

        int lengthOfColumns = 3 * n - 2;

        string firstPart = FirstPart(n, lengthOfColumns);
        string centerPart = Center(n, lengthOfColumns);

        var firstLines = firstPart.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        string reversedFirstPart = string.Join("\n", firstLines.Reverse());

        return $"{firstPart}{centerPart}{reversedFirstPart}";
    }

    static string FirstPart(int n, int lengthOfColumns)
    {
        int actualAddedNumber = 1;
        int iteratorForColumns = 0;
        var result = "";

        while (iteratorForColumns != n - 1)
        {
            string number = actualAddedNumber.ToString();
            result += new string(' ', n - 1)
                      + new string(number[number.Length - 1], n)
                      + new string(' ', n - 1)
                      + '\n';

            actualAddedNumber++;

            if (actualAddedNumber == 10)
            {
                actualAddedNumber = 0;
            }

            iteratorForColumns++;
        }

        return result;
    }

    static string Center(int n, int lengthOfColumns)
    {
        string result = "";
        string beforeTheCenterNumbers = "";
        string center = new string(n.ToString()[n.ToString().Length - 1], n);
        string afterTheCenterNumbers = "";

        int actualAddedNumber = 1;

        for (int i = 0; i < n - 1; i++)
        {
            beforeTheCenterNumbers += actualAddedNumber.ToString()[actualAddedNumber.ToString().Length - 1];
            actualAddedNumber++;

            if (actualAddedNumber == 10)
            {
                actualAddedNumber = 0;
            }
        }

        actualAddedNumber = n - 1;

        for (int i = 0; i < n - 1; i++)
        {
            afterTheCenterNumbers += actualAddedNumber.ToString()[actualAddedNumber.ToString().Length - 1];
            actualAddedNumber--;

            if (actualAddedNumber < 0)
            {
                actualAddedNumber = 9;
            }
        }

        string line = $"{beforeTheCenterNumbers}{center}{afterTheCenterNumbers}";
        return string.Concat(Enumerable.Repeat(line + "\n", n));
    }
}
//https://www.codewars.com/kata/5589ad588ee1db3f5e00005a/train/csharp