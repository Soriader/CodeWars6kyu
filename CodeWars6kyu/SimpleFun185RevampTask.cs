namespace CodeWars6kyu;

public class SimpleFun185RevampTask
{
    public string Revamp(string s)
    {
        var words = s.Split(" ")
            .Select(word => new string(word.OrderBy(c => c).ToArray()))
            .ToArray();
        List<string> alphabetWords = new List<string>(words);
        
        var sortedWords = words.OrderBy(word => word.Sum(c => (int)c)) 
            .ThenBy(word => word.Length)           
            .ThenBy(word => word)                  
            .ToList();

        string result = string.Join(" ", sortedWords);

        return result;
    }
}
//https://www.codewars.com/kata/58bcfe1e23fee9fd95000007/train/csharp