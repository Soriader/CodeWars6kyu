using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class HollowArray
{
    [Test]
    public void HollowArrayTest()
    {
        Assert.AreEqual(true, HollowArrayTask.IsHollow(new int[] { -1, 0, 0, 0, 3 }));
        Assert.AreEqual(false, HollowArrayTask.IsHollow(new int[] { -1, 0, 0, 0, 0 }));
    }
}