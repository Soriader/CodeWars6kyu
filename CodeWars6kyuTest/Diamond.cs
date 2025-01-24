using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class Diamond
{
    [Test]
    public void DiamondTest()
    {
        Assert.AreEqual("      1      \n     121     \n    12321    \n   1234321   \n  123454321  \n 12345654321 \n1234567654321\n 12345654321 \n  123454321  \n   1234321   \n    12321    \n     121     \n      1      ", DiamondTask.Pattern(7));
        Assert.AreEqual("1", DiamondTask.Pattern(1));
        Assert.AreEqual("  1  \n 121 \n12321\n 121 \n  1  ", DiamondTask.Pattern(3));
        Assert.AreEqual("", DiamondTask.Pattern(0));
        Assert.AreEqual("", DiamondTask.Pattern(-25));
    }
}