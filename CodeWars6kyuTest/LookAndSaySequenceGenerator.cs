using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class LookAndSaySequenceGenerator
{
    [Test]
    public void LookAndSaySequenceGeneratorTest()
    {
        Assert.AreEqual("1", LookAndSaySequenceGeneratorTask.LookAndSaySequence("1", 1));
        Assert.AreEqual("21", LookAndSaySequenceGeneratorTask.LookAndSaySequence("1", 3));
        Assert.AreEqual("111221", LookAndSaySequenceGeneratorTask.LookAndSaySequence("1", 5));
        Assert.AreEqual("22", LookAndSaySequenceGeneratorTask.LookAndSaySequence("22", 10));
        Assert.AreEqual("1114", LookAndSaySequenceGeneratorTask.LookAndSaySequence("14", 2));
    }
}