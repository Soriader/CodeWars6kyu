using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class SelNumber
{
    [Test]
    public void SelNumberTest()
    {
        Assert.AreEqual(0, HowManyNumbersTask.SelNumber(0, 1));
        Assert.AreEqual(0, HowManyNumbersTask.SelNumber(3, 1));
        Assert.AreEqual(1, HowManyNumbersTask.SelNumber(13, 1));
        Assert.AreEqual(1, HowManyNumbersTask.SelNumber(15, 1));
        Assert.AreEqual(2, HowManyNumbersTask.SelNumber(20, 2));
        Assert.AreEqual(4, HowManyNumbersTask.SelNumber(30, 2));
        Assert.AreEqual(6, HowManyNumbersTask.SelNumber(44, 2));
        Assert.AreEqual(12, HowManyNumbersTask.SelNumber(50, 3));
        Assert.AreEqual(21, HowManyNumbersTask.SelNumber(100, 3));
    }
}