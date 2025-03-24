namespace CodeWars6kyu;

public class CalculatorAdditionAndSpacesPartOneTask
{
    public static int Calculate(string str)
    {
        var result = new List<int>();
        
        str = str.Replace(" ", "");
        var boxForNumbers = "";
        
        foreach (var c in str)
        {
            if (c == '+')
            {
                result.Add(int.Parse(boxForNumbers));
                boxForNumbers = "";
            }
            else
            {
                boxForNumbers += c;
            }
        }

        if (boxForNumbers.Length > 0)
        {
            result.Add(int.Parse(boxForNumbers));
        }
        
        return result.Sum();
    }
}
//https://www.codewars.com/kata/59512d72944ca1feb000013d/train/csharp