using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class FractionsClass
{
    [Test]
    public void FractionsClassTest()
    {
        Assert.AreEqual(new Fraction(37, 40), new Fraction(1, 8) + new Fraction(4, 5));
        Assert.AreEqual(new Fraction(1, 1), new Fraction(1, 4) + new Fraction(3, 4));
        Assert.AreEqual(new Fraction(863483, 416760), new Fraction(911, 920) + new Fraction(980, 906));
        Assert.AreEqual(new Fraction(838923, 926885), new Fraction(610, 941) + new Fraction(253, 985));
        Assert.AreEqual(new Fraction(16880, 3591), new Fraction(956, 798) + new Fraction(662, 189));
        Assert.AreEqual(new Fraction(1011239, 417585), new Fraction(694, 485) + new Fraction(853, 861));
        Assert.AreEqual(new Fraction(191737, 20757), new Fraction(982, 111) + new Fraction(219, 561));
        Assert.AreEqual(new Fraction(41201, 23571), new Fraction(344, 873) + new Fraction(658, 486));
        Assert.AreEqual(new Fraction(184563, 68951), new Fraction(662, 361) + new Fraction(322, 382));
        Assert.AreEqual(new Fraction(33926, 23577), new Fraction(740, 813) + new Fraction(184, 348));
        Assert.AreEqual(new Fraction(78524, 39543), new Fraction(579, 441) + new Fraction(543, 807));
        Assert.AreEqual(new Fraction(83997, 283910), new Fraction(212, 979) + new Fraction(46, 580));

        Assert.AreEqual(new Fraction(1, 2), new Fraction(4, 8));
        Assert.AreEqual(new Fraction(2, 3), new Fraction(10, 15));
        Assert.AreEqual(new Fraction(4, 9), new Fraction(24, 54));

        Assert.AreEqual("4/5", (new Fraction(2, 5) + new Fraction(2, 5)).ToString());
        Assert.AreEqual("5/6", (new Fraction(2, 4) + new Fraction(1, 3)).ToString());
        Assert.AreEqual("13/15", (new Fraction(1, 5) + new Fraction(4, 6)).ToString());
    }
}