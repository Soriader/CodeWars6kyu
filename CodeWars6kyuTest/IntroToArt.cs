namespace CodeWars6kyuTest;
using CodeWars6kyu;

public class IntroToArt
{
    [Test]
    public void IntroToArtTest() 
    {
        Assert.That(IntroToArtTask.GetW(1), Is.EqualTo(new string[] {}));
        Assert.That(IntroToArtTask.GetW(3), Is.EqualTo(new string[] {
            "*   *   *",
            " * * * * ",
            "  *   *  "
        }));
        Assert.That(IntroToArtTask.GetW(7), Is.EqualTo(new string[] {
            "*           *           *",
            " *         * *         * ",
            "  *       *   *       *  ",
            "   *     *     *     *   ",
            "    *   *       *   *    ", 
            "     * *         * *     ",
            "      *           *      "
        }));
    }
}
