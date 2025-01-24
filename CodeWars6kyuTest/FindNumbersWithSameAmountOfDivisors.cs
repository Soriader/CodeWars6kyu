using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class FindNumbersWithSameAmountOfDivisors
{
    [Test]
    public static void FindNumbersWithSameAmountOfDivisorsTest()
    {
        Assert.AreEqual(8, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(1, 50));
        Assert.AreEqual(7, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(3, 100));
        Assert.AreEqual(18, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(3, 200));
        Assert.AreEqual(86, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(6, 350));
        Assert.AreEqual(214, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(6, 1000));
        Assert.AreEqual(189, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(7, 1500));
        Assert.AreEqual(309, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(7, 2500));
        Assert.AreEqual(366, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(7, 3000));
        Assert.AreEqual(487, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(9, 4000));
        Assert.AreEqual(622, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(9, 5000));
        Assert.AreEqual(567, FindNumbersWithSameAmountOfDivisorsTask.CountPairsInt(11, 5000));

    }
}