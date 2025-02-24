namespace CodeWars6kyu;

public class CompleteThePattern16Task
{
    public static string Pattern(int n)
    {
        if (n < 1)
        {
            return "";
        }

        if (n == 1)
        {
            return "1";
        }
        
        string result = "";
        int boxForSecondSequence = 0;
        string boxForFirstSequence = "";

        if (n < 10)
        {
            boxForFirstSequence = $"{n}";
            boxForSecondSequence = n;
        }
        else
        {
            boxForFirstSequence = n.ToString().Last().ToString();
            boxForSecondSequence = int.Parse(boxForFirstSequence);
        }
        
        int iterator = 0;
        int iteratorToSecondSequence = n - 1;
            
        while (iterator != n)
        {
            result += boxForFirstSequence 
                      + string.Concat(Enumerable.Repeat(boxForSecondSequence, iteratorToSecondSequence)) 
                      + "\n";


            boxForSecondSequence--;
            iteratorToSecondSequence--;
            
            if (boxForSecondSequence < 0)
            {
                boxForSecondSequence = 9;
            }
            
            boxForFirstSequence += boxForSecondSequence;
            
            
            iterator++;
        }
        
        
        return result.TrimEnd('\n');
    }
}
//https://www.codewars.com/kata/55ae997d1c40a199e6000018/train/csharp