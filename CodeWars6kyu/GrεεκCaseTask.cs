namespace CodeWars6kyu;

public class GrεεκCaseTask
{
    public static string GreekL33t(string str)
    {

        Dictionary<char, char> lowerCaseMap = new Dictionary<char, char>
        {
            {'a', 'α'}, {'b', 'β'}, {'d', 'δ'}, {'e', 'ε'}, {'i', 'ι'},
            {'k', 'κ'}, {'n', 'η'}, {'o', 'θ'}, {'p', 'ρ'}, {'r', 'π'},
            {'t', 'τ'}, {'u', 'μ'}, {'v', 'υ'}, {'w', 'ω'}, {'x', 'χ'},
            {'y', 'γ'}
        };

        string result = "";
        var check = str.ToLower();
        
        foreach (char letter in check)
        {
            if (char.IsLetter(letter))
            {
                if (lowerCaseMap.ContainsKey(letter))
                {
                    result += lowerCaseMap[letter];
                }
                else
                {
                    result += letter;
                }
            }
            else
            {
                result += letter;
            }
            
        }
        
        return result;
    }
}
//https://www.codewars.com/kata/556025c8710009fc2d000011/train/csharp