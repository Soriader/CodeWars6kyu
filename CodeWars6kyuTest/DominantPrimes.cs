namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class DominantPrimes
{
    [Test]
    public void DominantPrimesTest()
    {
        Assert.That(DominantPrimesTask.Solve(0, 10), Is.EqualTo(8));
        Assert.That(DominantPrimesTask.Solve(2, 200), Is.EqualTo(1080));    
        Assert.That(DominantPrimesTask.Solve(1000, 100000), Is.EqualTo(52114889));
        Assert.That(DominantPrimesTask.Solve(4000, 500000), Is.EqualTo(972664400));
   
    }
}