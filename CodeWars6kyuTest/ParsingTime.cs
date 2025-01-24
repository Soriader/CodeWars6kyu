using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class ParsingTime
{
    [Test]
    public void ParsingTimeTest()
    {
        Assert.AreEqual(0, ParsingTimeTask.ToSeconds("00:00:00"));
        Assert.AreEqual(3723, ParsingTimeTask.ToSeconds("01:02:03"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("01:02:60"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("01:60:03"));
        Assert.AreEqual(359999, ParsingTimeTask.ToSeconds("99:59:59"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("0:00:00"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("00:0:00"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("00:00:0"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("00:00:00\n0"));
        Assert.AreEqual(null, ParsingTimeTask.ToSeconds("00\n00:00:00"));
    }
}