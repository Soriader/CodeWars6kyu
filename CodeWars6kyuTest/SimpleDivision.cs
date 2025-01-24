using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class SimpleDivision
{
    [Test]
    public void SimpleDivisionTest()
    {
        Assert.AreEqual(true, SimpleDivisionTask.Solve(2, 256));
        Assert.AreEqual(true, SimpleDivisionTask.Solve(21, 2893401));
        Assert.AreEqual(false, SimpleDivisionTask.Solve(2, 253));
        Assert.AreEqual(false, SimpleDivisionTask.Solve(21, 2893406));
    }
}