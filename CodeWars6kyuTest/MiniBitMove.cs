using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class MiniBitMove
{
    [Test]
    public void MiniBitMoveTest()
    {
        Assert.AreEqual(new bool[] { false, false, true, true, false, true, false }, MiniBitMoveTask.Interpreter("10", new bool[] { true, true, false, false, true, false, true }));
        Assert.AreEqual(new bool[] { false, true, false, true, false, true, false, true, false, true }, MiniBitMoveTask.Interpreter("100", new bool[] { true, true, true, true, true, true, true, true, true, true }));
    }
}