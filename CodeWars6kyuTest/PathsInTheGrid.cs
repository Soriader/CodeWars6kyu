namespace CodeWars6kyuTest;

using CodeWars6kyu;
using System.Numerics;

public class PathsInTheGrid
{
    [Test, Order(1)]
    public void FirstTest()
    {
        Assert.That(PathsInTheGridTask.NumberOfRoutes(1, 1), Is.EqualTo(BigInteger.Parse("2")));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        Assert.That(PathsInTheGridTask.NumberOfRoutes(5, 1), Is.EqualTo(BigInteger.Parse("6")));
    }

    [Test, Order(3)]
    public void ThirdTest()
    {
        Assert.That(PathsInTheGridTask.NumberOfRoutes(3, 4), Is.EqualTo(BigInteger.Parse("35")));
    }
}