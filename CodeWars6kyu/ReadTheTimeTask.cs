namespace CodeWars6kyu;

public class ReadTheTimeTask
{
    public static string Solve(string time)
    {
        if (time == "00:00")
        {
            return "midnight";
        }

        var partOfTime = time.Split(':');
        int hour = int.Parse(partOfTime[0]);
        int minute = int.Parse(partOfTime[1]);

        bool isMidnight = hour == 0;
        bool isAlmostMidnight = hour == 23;

        string hourWord = isMidnight ? "midnight" : HourToWords(hour % 12 == 0 ? 12 : hour % 12);
        string minuteWord = MinutesToWords(minute);

        if (minute == 0)
        {
            return $"{hourWord} o'clock";
        }
        else if (minute == 15)
        {
            return $"quarter past {hourWord}";
        }
        else if (minute == 30)
        {
            return $"half past {hourWord}";
        }
        else if (minute == 45)
        {
            string nextHourWord = isAlmostMidnight ? "midnight" : (isMidnight ? "one" : HourToWords((hour + 1) % 12 == 0 ? 12 : (hour + 1) % 12));
            return $"quarter to {nextHourWord}";
        }
        else if (minute < 30)
        {
            return $"{minuteWord} {(minute == 1 ? "minute" : "minutes")} past {hourWord}";
        }
        else
        {
            string nextHourWord = isAlmostMidnight ? "midnight" : (isMidnight ? "one" : HourToWords((hour + 1) % 12 == 0 ? 12 : (hour + 1) % 12));
            return $"{MinutesToWords(60 - minute)} {(60 - minute == 1 ? "minute" : "minutes")} to {nextHourWord}";
        }
    }

    private static string HourToWords(int number)
    {
        var numbers = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
        };

        return numbers.ContainsKey(number) ? numbers[number] : "Number out of range";
    }

    public static string MinutesToWords(int minutes)
    {
        if (minutes < 0 || minutes > 59)
        {
            return "Invalid minute value";
        }

        var numbers = new Dictionary<int, string>
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "quarter" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" }
        };

        if (numbers.ContainsKey(minutes))
        {
            return numbers[minutes];
        }

        int tens = (minutes / 10) * 10;
        int ones = minutes % 10;

        return numbers[tens] + " " + numbers[ones];
    }
}
//https://www.codewars.com/kata/5c2b4182ac111c05cf388858/train/csharp