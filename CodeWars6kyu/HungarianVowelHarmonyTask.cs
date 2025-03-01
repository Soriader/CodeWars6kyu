namespace CodeWars6kyu;

public class HungarianVowelHarmonyTask
{
    public static string Instrumental(string word)
    {
        var frontVowels = "eéiíöőüű";
        var backVowels = "aáoóuú";
        var digraphs = new List<string> { "sz", "zs", "cs" };
        var vowelPairs = new Dictionary<char, char>
        {
            { 'a', 'á' },
            { 'e', 'é' },
            { 'i', 'í' },
            { 'o', 'ó' },
            { 'u', 'ú' },
            { 'ö', 'ő' },
            { 'ü', 'ű' }
        };

        char lastVowel = '\0';
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (frontVowels.Contains(word[i]) || backVowels.Contains(word[i]))
            {
                lastVowel = word[i];
                break;
            }
        }

        if (lastVowel == '\0')
        {
            return word;
        }

        if (frontVowels.Contains(word[word.Length - 1]) || backVowels.Contains(word[word.Length - 1]))
        {
            char lastChar = word[word.Length - 1];
            if (vowelPairs.ContainsKey(lastChar))
            {
                word = word.Substring(0, word.Length - 1) + vowelPairs[lastChar];
            }

            if (frontVowels.Contains(lastVowel))
            {
                return word + "vel";
            }
            else
            {
                return word + "val";
            }
        }
        else
        {

            string lastTwoLetters = word.Length >= 2 ? word.Substring(word.Length - 2) : "";
            if (digraphs.Contains(lastTwoLetters))
            {
                word = word.Substring(0, word.Length - 2) + lastTwoLetters[0] + lastTwoLetters;
            }
            else
            {
                word = word + word[word.Length - 1];
            }

            if (frontVowels.Contains(lastVowel))
            {
                return word + "el";
            }
            else
            {
                return word + "al";
            }
        }
    }
}
//https://www.codewars.com/kata/57fe5b7108d102fede00137a/train/csharp