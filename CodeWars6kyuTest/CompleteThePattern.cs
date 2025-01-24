using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class CompleteThePattern
{
    [Test]
    public void CompleteThePatternTest()
    {
        Assert.AreEqual("1   1\n 2 2 \n  3  \n 2 2 \n1   1", CompleteThePatternTask.Pattern(3));
        Assert.AreEqual("1       1\n 2     2 \n  3   3  \n   4 4   \n    5    \n   4 4   \n  3   3  \n 2     2 \n1       1", CompleteThePatternTask.Pattern(5));
    }
}