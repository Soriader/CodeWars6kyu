namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class CompleteThePatternPlus
{
    [Test]
    public void CompleteThePatternPlusTest()
    {
        var expected = "  111  \n  222  \n1233321\n1233321\n1233321\n  222  \n  111  ";
        Assert.That(CompleteThePatternPlusTask.Pattern(3), Is.EqualTo(expected));
        expected = "    11111    \n    22222    \n    33333    \n    44444    \n1234555554321\n1234555554321\n1234555554321\n1234555554321\n1234555554321\n    44444    \n    33333    \n    22222    \n    11111    ";
        Assert.That(CompleteThePatternPlusTask.Pattern(5), Is.EqualTo(expected));
    }
}