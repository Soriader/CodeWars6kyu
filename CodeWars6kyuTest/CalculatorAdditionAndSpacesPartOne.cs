namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class CalculatorAdditionAndSpacesPartOne
{
    [Test]
    public void CalculatorAdditionAndSpacesPartOneTest()
    {
        Assert.That(CalculatorAdditionAndSpacesPartOneTask.Calculate("1+2+3"), Is.EqualTo(6));
        Assert.That(CalculatorAdditionAndSpacesPartOneTask.Calculate("1+2 3"), Is.EqualTo(24));
        Assert.That(CalculatorAdditionAndSpacesPartOneTask.Calculate("1 2 3"), Is.EqualTo(123));
    }
}
