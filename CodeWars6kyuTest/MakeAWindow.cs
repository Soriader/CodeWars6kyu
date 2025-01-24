using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class MakeAWindow
{
    [Test]
    public void MakeAWindowTest()
    {
        Assert.AreEqual("-----\n|.|.|\n|-+-|\n|.|.|\n-----", MakeAWindowTask.MakeAWindow(1));
        Assert.AreEqual("---------\n|...|...|\n|...|...|\n|...|...|\n|---+---|\n|...|...|\n|...|...|\n|...|...|\n---------", MakeAWindowTask.MakeAWindow(3));

    }
}