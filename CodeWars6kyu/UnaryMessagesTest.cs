using System.Text;

namespace CodeWars6kyu;

public class UnaryMessagesTest
{
    public static string Send(string text)
    {
        string binaryString = StringToBinary(text).Replace(" ", "");
        
        if (string.IsNullOrEmpty(binaryString))
        {
            return "";
        }
        
        StringBuilder result = new StringBuilder();
        char currentBit = binaryString[0];
        int count = 1;

        for (int i = 1; i < binaryString.Length; i++)
        {
            if (binaryString[i] == currentBit)
            {
                count++;
            }
            else
            {
                result.Append(currentBit == '1' ? "0 " : "00 ");
                result.Append(new string('0', count)).Append(" ");

                currentBit = binaryString[i];
                count = 1;
            }
        }

        result.Append(currentBit == '1' ? "0 " : "00 ");
        result.Append(new string('0', count));

        return result.ToString().Trim();
    }

    public static string Receive(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return "";
        }
        
        string[] blocks = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder binaryResult = new StringBuilder();

        for (int i = 0; i < blocks.Length; i += 2)
        {
            string seriesType = blocks[i];
            string seriesLength = blocks[i + 1];

            char bit = (seriesType == "0") ? '1' : '0';
            int length = seriesLength.Length;

            binaryResult.Append(bit, length);
        }

        StringBuilder decodedText = new StringBuilder();
        for (int i = 0; i < binaryResult.Length; i += 7)
        {
            if (i + 7 > binaryResult.Length)
            {
                break;
            }
            
            string binaryChar = binaryResult.ToString().Substring(i, 7);
            int asciiValue = Convert.ToInt32(binaryChar, 2);
            decodedText.Append((char)asciiValue);
        }

        return decodedText.ToString();
    }

    
    public static string StringToBinary(string input)
    {
        StringBuilder binaryString = new StringBuilder();
    
        foreach (char c in input)
        {
            string binary = Convert.ToString(c, 2).PadLeft(7, '0');
            binaryString.Append(binary);
            binaryString.Append(' ');
        }
    
        return binaryString.ToString().Trim();
    }
}

//https://www.codewars.com/kata/5e5ccbda30e9d0001ec77bb6/train/csharp