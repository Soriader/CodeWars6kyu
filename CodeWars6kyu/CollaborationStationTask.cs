using System.Text;

namespace CodeWars6kyu;

public class CollaborationStationTask
{
    public static string[] SplitMessage(string message, int count)
    {
        if (count <= 0)
        {
            return null;
        }
        if (message == null)
        {
            message = ""; 
        }

        var result = new List<string>();

        for (int friendIndex = 0; friendIndex < count; friendIndex++)
        {
            var encryptedMessage = new StringBuilder(message.Length);
            int currentPositon = friendIndex;

            for (int i = 0; i < message.Length; i++)
            {
                encryptedMessage.Append(i == currentPositon ? message[i] : '-');
                
                if (i == currentPositon)
                {
                    currentPositon += count;
                }
            }

            result.Add(encryptedMessage.ToString());
        }

        return result.ToArray();
    }
}
//https://www.codewars.com/kata/57b31dc11fae8a4137000693/train/csharp