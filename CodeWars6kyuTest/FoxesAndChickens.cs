namespace CodeWars6kyuTest;

using CodeWars6kyu;


public class FoxesAndChickens
{
    [Test]
    public void Example1()
    {
        string before = "CCC[CCC]FCC[CCCCC]CFFFF[CCC]FFFF";
        string after = "...[CCC]F..[CCCCC].FFFF[CCC]FFFF";
        Assert.That(FoxesAndChickensTask.HungryFoxes(before), Is.EqualTo(after));
    }

    [Test]
    public void Example2()
    {
        string before = "...[CCC]...[CCCFC].....[CCC]....";
        string after = "...[CCC]...[...F.].....[CCC]....";
        Assert.That(FoxesAndChickensTask.HungryFoxes(before), Is.EqualTo(after));
    }
    
    [Test]
    public void Example3()
    {
        string before = "CCC[CCC]FCC[CCCFC]CFFFF[CCC]FFFF";
        string after = "...[CCC]F..[...F.].FFFF[CCC]FFFF";
        Assert.That(FoxesAndChickensTask.HungryFoxes(before), Is.EqualTo(after));
    }
}