namespace CodeWars6kyu;

public class CleverSplitTask
{
    public static string[] CleverSplit(string s)
    {
        var boxVorResult = new List<string>();
        var boxForWords = "";
        bool isOnBrackets = false;

        foreach (var letter in s)
        {
            if (letter == '[')
            {
                isOnBrackets = true;
            }

            if (letter == ' ' && !isOnBrackets)
            {
                if (!string.IsNullOrEmpty(boxForWords))
                {
                    boxVorResult.Add(boxForWords);
                    boxForWords = "";
                }
                continue;
            }

            boxForWords += letter;

            if (letter == ']')
            {
                isOnBrackets = false;
                boxVorResult.Add(boxForWords);
                boxForWords = "";
            }
        }

        if (!string.IsNullOrEmpty(boxForWords))
        {
            boxVorResult.Add(boxForWords);
        }

        return boxVorResult.ToArray();
    }
}
//https://www.codewars.com/kata/5992e11d6ca73b38d50000f0/train/csharp