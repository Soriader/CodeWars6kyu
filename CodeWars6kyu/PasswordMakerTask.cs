namespace CodeWars6kyu;

public class PasswordMakerTask
{
    private static readonly Random Random = new Random();
    public static string MakePassword(int len, bool upper, bool lower, bool digits)
    {
        var charPool = new List<char>();
        if (upper) charPool.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        if (lower) charPool.AddRange("abcdefghijklmnopqrstuvwxyz");
        if (digits) charPool.AddRange("0123456789");

        if (charPool.Count < len)
        {
            throw new ArgumentException("Error! The length of the password is too short!");

        }

        var password = new char[len];
        var usedChars = new HashSet<char>();

        int index = 0;
        if (upper)
        {
            var upperChars = charPool.Where(char.IsUpper).ToList();
            password[index++] = upperChars[Random.Next(upperChars.Count)];
            usedChars.Add(password[index - 1]);
        }
        if (lower)
        {
            var lowerChars = charPool.Where(char.IsLower).ToList();
            password[index++] = lowerChars[Random.Next(lowerChars.Count)];
            usedChars.Add(password[index - 1]);
        }
        if (digits)
        {
            var digitChars = charPool.Where(char.IsDigit).ToList();
            password[index++] = digitChars[Random.Next(digitChars.Count)];
            usedChars.Add(password[index - 1]);
        }

        while (index < len)
        {
            char randomChar = charPool[Random.Next(charPool.Count)];
            if (!usedChars.Contains(randomChar))
            {
                password[index++] = randomChar;
                usedChars.Add(randomChar);
            }
        }

        Shuffle(password);

        return new string(password);
    }
    private static void Shuffle(char[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = Random.Next(i + 1);
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
//https://www.codewars.com/kata/5b3d5ad43da310743c000056/train/csharp