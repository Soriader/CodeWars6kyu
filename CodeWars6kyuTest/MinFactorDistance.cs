namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class MinFactorDistance
{
    [Test]
    public void MinFactorDistanceTest()
    {
        Assert.That(MinFactorDistanceTask.MinDistance(8), Is.EqualTo(1));
        Assert.That(MinFactorDistanceTask.MinDistance(25), Is.EqualTo(4));
        Assert.That(MinFactorDistanceTask.MinDistance(13013), Is.EqualTo(2));
        Assert.That(MinFactorDistanceTask.MinDistance(557009), Is.EqualTo(200));
        Assert.That(MinFactorDistanceTask.MinDistance(218683), Is.EqualTo(198));
    }
}