using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class AddingBinaryNumbers
{
    [Test]
    public void AddingBinaryNumbersTest()
    {
        Assert.AreEqual("1001", AddingBinaryNumbersTask.Add("111", "10"));
        Assert.AreEqual("10010", AddingBinaryNumbersTask.Add("1101", "101"));
        Assert.AreEqual("100100", AddingBinaryNumbersTask.Add("1101", "10111"));
        Assert.AreEqual("11", AddingBinaryNumbersTask.Add("0011", "00"));
        Assert.AreEqual("11", AddingBinaryNumbersTask.Add("00", "0011"));
    }
}