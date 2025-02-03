using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class ReadTheTime
{
  [Test]
  public void ExampleTests()
  {
    Assert.That(ReadTheTimeTask.Solve("13:00"), Is.EqualTo("one o'clock"));
    Assert.That(ReadTheTimeTask.Solve("13:09"), Is.EqualTo("nine minutes past one"));
    Assert.That(ReadTheTimeTask.Solve("13:15"), Is.EqualTo("quarter past one"));
    Assert.That(ReadTheTimeTask.Solve("13:29"), Is.EqualTo("twenty nine minutes past one"));
    Assert.That(ReadTheTimeTask.Solve("13:30"), Is.EqualTo("half past one"));
    Assert.That(ReadTheTimeTask.Solve("13:31"), Is.EqualTo("twenty nine minutes to two"));
    Assert.That(ReadTheTimeTask.Solve("13:45"), Is.EqualTo("quarter to two"));
    Assert.That(ReadTheTimeTask.Solve("13:59"), Is.EqualTo("one minute to two"));
    Assert.That(ReadTheTimeTask.Solve("00:48"), Is.EqualTo("twelve minutes to one"));
    Assert.That(ReadTheTimeTask.Solve("00:08"), Is.EqualTo("eight minutes past midnight"));
    Assert.That(ReadTheTimeTask.Solve("12:00"), Is.EqualTo("twelve o'clock"));
    Assert.That(ReadTheTimeTask.Solve("00:00"), Is.EqualTo("midnight"));
    Assert.That(ReadTheTimeTask.Solve("19:01"), Is.EqualTo("one minute past seven"));
    Assert.That(ReadTheTimeTask.Solve("07:01"), Is.EqualTo("one minute past seven"));
    Assert.That(ReadTheTimeTask.Solve("01:59"), Is.EqualTo("one minute to two"));
    Assert.That(ReadTheTimeTask.Solve("12:01"), Is.EqualTo("one minute past twelve"));
    Assert.That(ReadTheTimeTask.Solve("00:01"), Is.EqualTo("one minute past midnight"));
    Assert.That(ReadTheTimeTask.Solve("11:31"), Is.EqualTo("twenty nine minutes to twelve"));
    Assert.That(ReadTheTimeTask.Solve("23:31"), Is.EqualTo("twenty nine minutes to midnight"));
    Assert.That(ReadTheTimeTask.Solve("00:01"), Is.EqualTo("one minute past midnight"));
    Assert.That(ReadTheTimeTask.Solve("11:45"), Is.EqualTo("quarter to twelve"));
    Assert.That(ReadTheTimeTask.Solve("11:59"), Is.EqualTo("one minute to twelve"));
    Assert.That(ReadTheTimeTask.Solve("23:45"), Is.EqualTo("quarter to midnight"));
    Assert.That(ReadTheTimeTask.Solve("23:59"), Is.EqualTo("one minute to midnight"));
    Assert.That(ReadTheTimeTask.Solve("01:45"), Is.EqualTo("quarter to two")); 
   
  }
}