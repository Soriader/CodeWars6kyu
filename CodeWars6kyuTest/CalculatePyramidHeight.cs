using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class CalculatePyramidHeight
{
    [Test]
    public void CalculatePyramidHeightTest()
    {
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(1), Is.EqualTo(1));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(4), Is.EqualTo(1));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(5), Is.EqualTo(2));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(29), Is.EqualTo(3));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(30), Is.EqualTo(4));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(31), Is.EqualTo(4));
        Assert.That(CalculatePyramidHeightTask.PyramidHeight(1240), Is.EqualTo(15));      
    }
}