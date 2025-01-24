using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class GroupIn10s
{
    [Test]
    public void GroupIn10sTest()
    {
        var expected = new int[][] { new int[] { 1, 2, 3 } };
        Assert.AreEqual(expected, GroupIn10sTask.GroupIn10s(new int[] { 1, 2, 3 }));

        expected = new int[][] { new int[] { 3, 8 },
            new int[] { 12, 17, 19 },
            new int[] { 25 },
            new int[] { 35, 38 },
            null,
            new int[] { 50 } };
        Assert.AreEqual(expected, GroupIn10sTask.GroupIn10s(new int[] { 8, 12, 38, 3, 17, 19, 25, 35, 50 }));
    }
}