using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class ShorterPath
{
    [Test]
    public static void ShorterPathTest()
    {
        string[] goal = new string[8] { "N", "N", "N", "N", "N", "E", "N", "N" };
        string[] answer = new string[8] { "N", "N", "N", "N", "N", "N", "N", "E" };
        Assert.That(ShorterPathTask.Directions(goal), Is.EqualTo(answer));
    }
}