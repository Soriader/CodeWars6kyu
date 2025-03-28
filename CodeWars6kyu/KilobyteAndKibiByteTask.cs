using System.Globalization;

namespace CodeWars6kyu;

public class KilobyteAndKibiByteTask
{
    public static string MemorySizeConversion(string memorySize) 
    {
        string[] parts = memorySize.Split(' ');
        double value = double.Parse(parts[0], CultureInfo.InvariantCulture);
        string unit = parts[1];
    
        switch (unit)
        {
            case "kB":
            {
                return $"{(value / 1.024).ToString("0.###", CultureInfo.InvariantCulture)} KiB";
            }
            case "KiB":
            {
                return $"{(value * 1.024).ToString("0.###", CultureInfo.InvariantCulture)} kB";
            }
            case "MB":
            {
                return $"{(value / 1.048576).ToString("0.###", CultureInfo.InvariantCulture)} MiB";
            }
            case "MiB":
            {
                return $"{(value * 1.048576).ToString("0.###", CultureInfo.InvariantCulture)} MB";
            }
            case "GB":
            {
                return $"{(value / 1.073741824).ToString("0.###", CultureInfo.InvariantCulture)} GiB";
            }
            case "GiB":
            {
                return $"{(value * 1.073741824).ToString("0.###", CultureInfo.InvariantCulture)} GB";
            }
            case "TB":
            {
                return $"{(value / 1.099511627776).ToString("0.###", CultureInfo.InvariantCulture)} TiB";
            }
            case "TiB":
            {
                return $"{(value * 1.099511627776).ToString("0.###", CultureInfo.InvariantCulture)} TB";
            }
            default:
            {
                return memorySize;
            }
        }
    }
}
//https://www.codewars.com/kata/5a115ff080171f9651000046/train/csharp