using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class MinutesToMidnight
{
    [Test]
    public void MinutesToMidnightTest()
    {
        MinutesToMidnightTask m = new MinutesToMidnightTask();
        DateTime testDate = DateTime.Now.Date.AddHours(12);
        Assert.That(m.CountMinutes(testDate), Is.EqualTo("720 minutes"));

        testDate = DateTime.Now.Date.AddHours(23).AddMinutes(59);
        Assert.That(m.CountMinutes(testDate), Is.EqualTo("1 minute"));
    }
}