namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class CuckooClock
{
        [Test, Order(1)]
    public void SimpleTests()
    {
          List<string> initialTimes = new List<string> { "07:22", "12:22", "01:30", "04:01", "03:38" };
          List<int> chimes = new List<int> { 1, 2, 2, 10, 19 };
          List<string> expectedTimes = new List<string> { "07:30", "12:45", "01:45", "05:30", "06:00" };

          for (int i = 0; i < initialTimes.Count; i++)
          {
              Assert.That(CuckooClockTask.CuckooClock(initialTimes[i], chimes[i]), Is.EqualTo(expectedTimes[i]));
          }
    }
    
    [Test, Order(2)]
    public void HourTests() // Test case where the starting time is 00, i.e. on the hour
    {
          List<string> initialTimes = new List<string> { "10:00", "10:00", "10:00", "10:00", "10:00" };
          List<int> chimes = new List<int> { 1, 10, 11, 13, 20 };
          List<string> expectedTimes = new List<string> { "10:00", "10:00", "10:15", "10:45", "11:00" };

          for (int i = 0; i < initialTimes.Count; i++)
          {
              Assert.That(CuckooClockTask.CuckooClock(initialTimes[i], chimes[i]), Is.EqualTo(expectedTimes[i]));
          }
    }
  
    [Test, Order(3)]
    public void TwelveTests() // Test going from twelve to one
    {
          List<string> initialTimes = new List<string> { "12:30", "12:30", "12:30", "12:30", "09:53" };
          List<int> chimes = new List<int> { 1, 2, 3, 4, 50 };
          List<string> expectedTimes = new List<string> { "12:30", "12:45", "01:00", "01:15", "02:30" };

          for (int i = 0; i < initialTimes.Count; i++)
          {
              Assert.That(CuckooClockTask.CuckooClock(initialTimes[i], chimes[i]), Is.EqualTo(expectedTimes[i]));
          }
    }
  
    [Test, Order(4)]
    public void AroundTheClockTests() // Test going more than 12 hours ahead
    {
          List<string> initialTimes = new List<string> { "08:17", "08:17", "08:17", "08:17", "08:17" };
          List<int> chimes = new List<int> { 113, 114, 115, 150, 200 };
          List<string> expectedTimes = new List<string> { "08:00", "08:15", "08:30", "11:00", "05:45" };

          for (int i = 0; i < initialTimes.Count; i++)
          {
              Assert.That(CuckooClockTask.CuckooClock(initialTimes[i], chimes[i]), Is.EqualTo(expectedTimes[i]));
          }
    }
}