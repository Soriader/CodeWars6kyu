namespace CodeWars6kyu;

public class CuckooClockTask
{
    public static string CuckooClock(string inputTime, int chimes)
    {
        int howManyChimes = 0;

        var actualTime = inputTime.Split(':');
        int startHour = int.Parse(actualTime[0]);
        int startMinutes = int.Parse(actualTime[1]);

        if (startMinutes == 0)
        {
            howManyChimes += startHour;
        }
        else if (startMinutes % 15 == 0)
        {
            howManyChimes++;
        }

        while (howManyChimes < chimes)
        {
            startMinutes++;

            if (startMinutes == 60)
            {
                startMinutes = 0;
                startHour++;
                if (startHour > 12)
                {
                    startHour = 1;
                }
                howManyChimes += startHour;
            }
            else if (startMinutes % 15 == 0)
            {
                howManyChimes++;
            }
        }

        if (startMinutes == 0)
        {
            return $"{startHour:D2}:00";
        }
        else
        {
            return $"{startHour:D2}:{startMinutes:D2}";
        }
    }
}
//https://www.codewars.com/kata/656e4602ee72af0017e37e82/train/csharp