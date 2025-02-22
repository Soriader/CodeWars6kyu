namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class GrεεκCase
{
    [Test]
    public void GrεεκCaseTest()
    {
        Assert.That(GrεεκCaseTask.GreekL33t("codewars"), Is.EqualTo("cθδεωαπs"));
        Assert.That(GrεεκCaseTask.GreekL33t("kata"), Is.EqualTo("κατα"));
        Assert.That(GrεεκCaseTask.GreekL33t("kumite"), Is.EqualTo("κμmιτε"));
        Assert.That(GrεεκCaseTask.GreekL33t("greekleet"), Is.EqualTo("gπεεκlεετ"));
    }
}