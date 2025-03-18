using System.Globalization;

namespace CodeWars6kyu;

public static class FormatNumberAsCurrencyUsingExtensionMethodTask
{
    public static string ToCurrency(this decimal number, string currencyPrefix)
    {
        if (number < 0)
        {
            return $"-{currencyPrefix}{Math.Abs(number).ToString("F2", CultureInfo.InvariantCulture)}";
 
        }
        
        return $"{currencyPrefix}{number.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
//https://www.codewars.com/kata/553133a9685e7a34aa00001c/train/csharp