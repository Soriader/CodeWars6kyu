namespace CodeWars6kyu;

public class StringSubpatternRecognitionIITask
{
    public static bool HasSubpattern(string str)
    {
        char[] arr = str.ToCharArray();
            
        Dictionary<string, int> counter = new Dictionary<string, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (counter.ContainsKey(arr[i].ToString()))
            {
                counter[arr[i].ToString()]++;
            }
            else
            {
                counter.TryAdd(arr[i].ToString(), 1);
            }
        }

        var counterList = counter.Values.ToList();

        for (int i = 2; i <= str.Length; i++)
        {
            if (counterList.All(count => count % i == 0))
            {
                return true;
            }
        }

        return false;
    }
}

//https://www.codewars.com/kata/5a4a391ad8e145cdee0000c4/train/csharp