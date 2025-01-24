using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class PossibilitiesOfThrowingACoin
{
    [Test]
    public void PossibilitiesOfThrowingACoinTest()
    {
        PossibilitiesOfThrowingACoinTask c = new PossibilitiesOfThrowingACoinTask();

        Assert.AreEqual(new List<string>() { "H", "T" }, c.Coin(1));
        Assert.AreEqual(new List<string>() { "HH", "HT", "TH", "TT" }, c.Coin(2));
        Assert.AreEqual(new List<string>() { "HHH", "HHT", "HTH", "HTT", "THH", "THT", "TTH", "TTT" }, c.Coin(3));
    }
}