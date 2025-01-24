using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class StringPyramid
{
    [Test]
    public void StringPyramidTest()
    {
        void Visualisation(string expectedWatchFromSide, string expectedWatchFromAbove, string actualWatchFromSide, string actualWatchFromAbove)
        {
            Console.WriteLine("From side correct:\n" + expectedWatchFromSide);
            Console.WriteLine("From above correct:\n" + expectedWatchFromAbove);
            Console.WriteLine("From side yours:\n" + actualWatchFromSide);
            Console.WriteLine("From above yours:\n" + actualWatchFromAbove);
            Assert.That(actualWatchFromSide, Is.EqualTo(expectedWatchFromSide));
            Assert.That(actualWatchFromAbove, Is.EqualTo(expectedWatchFromAbove));
        }

        string characters = "abc";
        string expectedWatchFromSide =
            "  c  \n" +
            " bbb \n" +
            "aaaaa";
        string expectedWatchFromAbove =
            "aaaaa\n" +
            "abbba\n" +
            "abcba\n" +
            "abbba\n" +
            "aaaaa";
        var actualWatchFromSide = StringPyramidTask.WatchPyramidFromTheSide(characters);
        var actualWatchFromAbove = StringPyramidTask.WatchPyramidFromAbove(characters);
        Visualisation(expectedWatchFromSide, expectedWatchFromAbove, actualWatchFromSide, actualWatchFromAbove);
        Assert.That(StringPyramidTask.CountVisibleCharactersOfThePyramid(characters), Is.EqualTo(25));
        Assert.That(StringPyramidTask.CountAllCharactersOfThePyramid(characters), Is.EqualTo(35));
    }
}