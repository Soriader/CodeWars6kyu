using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class TimeLikeStringFormat
{
    [Test]
    public void TimeLikeStringFormatTest()
    {
        Assert.That(() => TimeLikeStringFormatTask.FormatTime(80), Throws.ArgumentException);
        Assert.That(TimeLikeStringFormatTask.FormatTime(1000), Is.EqualTo("10:00"));

    }
}