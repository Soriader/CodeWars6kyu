using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class SimpleSumOfPairs
{
    [Test]
    public void SimpleSumOfPairsTest()
    {
        Assert.That(SimpleSumOfPairsTask.Solve(0), Is.EqualTo(0));
        Assert.That(SimpleSumOfPairsTask.Solve(1), Is.EqualTo(1));
        Assert.That(SimpleSumOfPairsTask.Solve(18), Is.EqualTo(18));
        Assert.That(SimpleSumOfPairsTask.Solve(29), Is.EqualTo(11));
        Assert.That(SimpleSumOfPairsTask.Solve(1140), Is.EqualTo(33));
        Assert.That(SimpleSumOfPairsTask.Solve(50000000), Is.EqualTo(68));
        Assert.That(SimpleSumOfPairsTask.Solve(15569047737), Is.EqualTo(144));
        Assert.That(SimpleSumOfPairsTask.Solve(2452148459), Is.EqualTo(116));

    }
}