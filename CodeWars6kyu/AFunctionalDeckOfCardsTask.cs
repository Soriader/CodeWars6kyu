namespace CodeWars6kyu;

public class AFunctionalDeckOfCardsTask
{
    public static string[] BuildDeck() => 
        new[] { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" }
            .SelectMany(card => new[] { " of hearts", " of spades", " of diamonds", " of clubs" }, 
                (card, symbol) => card + symbol)
            .ToArray();
}
//https://www.codewars.com/kata/535742c7e727388cdc000297/train/csharp