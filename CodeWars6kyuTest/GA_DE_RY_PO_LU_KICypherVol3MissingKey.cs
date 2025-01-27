using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class GA_DE_RY_PO_LU_KICypherVol3MissingKey
{
    [Test]
    public void GA_DE_RY_PO_LU_KICypherVol3MissingKeyTest()
    {
        string[] messages = { "dance on the table", "hide my beers", "scouts rocks" };
        string[] secretes = { "egncd pn thd tgbud" ,"hked mr bddys" ,"scplts ypcis" };
        Assert.That(GA_DE_RY_PO_LU_KICypherVol3MissingKeyTask.FindTheKey(messages, secretes), Is.EqualTo("agdeikluopry"));               
    }
}