using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class KaKaKaCypher
{
    [Test]
    public void KaKaKaCypherTest()
    {
        Assert.AreEqual("kaka", KaKaKaCypherTask.KaCokadekaMe("ka"));
        Assert.AreEqual("kaa", KaKaKaCypherTask.KaCokadekaMe("a"));
        Assert.AreEqual("kaaa", KaKaKaCypherTask.KaCokadekaMe("aa"));
        Assert.AreEqual("kaz", KaKaKaCypherTask.KaCokadekaMe("z"));
        Assert.AreEqual("kaAkabbaa", KaKaKaCypherTask.KaCokadekaMe("Abbaa"));
        Assert.AreEqual("kamaikantekanakance", KaKaKaCypherTask.KaCokadekaMe("maintenance"));
        Assert.AreEqual("kaWookadie", KaKaKaCypherTask.KaCokadekaMe("Woodie"));
        Assert.AreEqual("kaIkancokamprekahekansikabikalikatiekas", KaKaKaCypherTask.KaCokadekaMe("Incomprehensibilities"));
    }
}