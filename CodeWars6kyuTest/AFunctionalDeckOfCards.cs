namespace CodeWars6kyuTest;

using CodeWars6kyu;
using System.Text;
using System.Collections;
using NUnit.Framework.Internal;
using System.Numerics;

[TestFixture]
public class AFunctionalDeckOfCards
{
    [Test]
    public void AFunctionalDeckOfCardsTest()
    {
        string[] deck = AFunctionalDeckOfCardsTask.BuildDeck();
        Assert.That(deck.Length, Is.EqualTo(52), "Your deck should have 52 cards");
    }
}