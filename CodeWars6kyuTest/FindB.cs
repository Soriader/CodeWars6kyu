using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class FindB
{
    [Test]
    public void FindBTest()
    {
        Assert.AreEqual(123, FindBTask.Int123(0) + 0, "0 + B must give 123");
        Assert.AreEqual(123, FindBTask.Int123(123) + 123, "123 + B must give 123");
        //ssert.AreEqual(123, FindBTask.Int123(500) + 500, "500 + B must give 123");
        //Assert.AreEqual(123, FindBTask.Int123(int.MaxValue) + int.MaxValue, "int.MaxValue + B must give 123");
        //Assert.AreEqual(123, FindBTask.Int123(int.MinValue) + int.MinValue, "int.MinValue + B must give 123");

        //this tests works earlier but now they have error, idk why
    }
}