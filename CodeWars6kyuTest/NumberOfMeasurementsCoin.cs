using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class NumberOfMeasurementsCoin
{
    [Test]
    public void NumberOfMeasurementsCoinTest()
    {
        Assert.That(NumberOfMeasurementsCoinTask.HowManyMeasurements(1), Is.EqualTo(0));
        Assert.That(NumberOfMeasurementsCoinTask.HowManyMeasurements(2), Is.EqualTo(1));
        Assert.That(NumberOfMeasurementsCoinTask.HowManyMeasurements(3), Is.EqualTo(1));
        Assert.That(NumberOfMeasurementsCoinTask.HowManyMeasurements(8), Is.EqualTo(2));
        Assert.That(NumberOfMeasurementsCoinTask.HowManyMeasurements(100), Is.EqualTo(5));
    }
}