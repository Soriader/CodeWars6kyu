using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class GA_DE_RY_PO_LU_KICypher
{
    [Test]
    public void GA_DE_RY_PO_LU_KICypherTest()
    {
        Assert.AreEqual("Ala has a cat", GA_DE_RY_PO_LU_KICypherTask.Encode("Gug hgs g cgt", "gaderypoluki"));
        Assert.AreEqual("gaderypoluki", GA_DE_RY_PO_LU_KICypherTask.Decode("agedyropulik", "gaderypoluki"));
        Assert.AreEqual("Dance on the table", GA_DE_RY_PO_LU_KICypherTask.Encode("Dkucr pu yhr ykbir", "politykarenu"));
        Assert.AreEqual("Hide our beers", GA_DE_RY_PO_LU_KICypherTask.Decode("Hmdr nge brres", "regulaminowy"));

    }
}