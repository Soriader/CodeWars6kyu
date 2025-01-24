using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class SnakesAndLadders
{
    [Test]
    public void SnakesAndLaddersTest()
    {
        var dice = new[] { 2, 1, 5, 1, 5, 4 };
        var board = new[] { 0, 0, 3, 0, 0, 0, 0, -2, 0, 0, 0 };
        Assert.That(SnakesAndLaddersTask.SnakesAndLadders(board, dice), Is.EqualTo(10));

        dice = new[] { 1, 4, 2, 7, 1, 3, 5, 7, 1 };
        board = new[] { 0, 0, 0, 0, 0, 0, 0, -1, 9, 0, 0, 0, 0, 0, -13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Assert.That(SnakesAndLaddersTask.SnakesAndLadders(board, dice), Is.EqualTo(17));

        dice = new[] { 3, 1, 5, 2, 1, 6, 4, 2, 6 };
        board = new[] { 0, 0, 0, 0, 4, 0, 4, -2, 0, 5, 0, 0, -9, 0, 0, -2, 0, 0, 0, 0, 0, 4, 0, -1, 0, 0, 0, 1, 0, 0 };
        Assert.That(SnakesAndLaddersTask.SnakesAndLadders(board, dice), Is.EqualTo(26));

    }
}