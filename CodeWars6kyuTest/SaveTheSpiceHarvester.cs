using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class SaveTheSpiceHarvester
{
    [Test]
    public void SaveTheSpiceHarvesterTest()
    {
        int[][] data = { new[] { 345, 600 }, new[] { 200, 100, 25 }, new[] { 350, 200, 32 } };
        Assert.That(SaveTheSpiceHarvesterTask.HarvesterRescue(data), Is.EqualTo("The spice must flow! Rescue the harvester!"));
    }
}