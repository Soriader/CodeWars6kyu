using System.Numerics;
using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class EasyDiagonal
{
    [Test]
    public void EasyDiagonalTest()
    {
        Assert.AreEqual(new BigInteger(20349), EasyDiagonalTask.Diagonal(20, 4));
        Assert.AreEqual(new BigInteger(5985), EasyDiagonalTask.Diagonal(20, 3));
        Assert.AreEqual(new BigInteger(54264), EasyDiagonalTask.Diagonal(20, 5));
    }
}