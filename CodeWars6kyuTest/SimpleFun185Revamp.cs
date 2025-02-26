namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class SimpleFun185Revamp
{
    [Test]
    public void SimpleFun185RevampTest(){
        var kata=new SimpleFun185RevampTask();

        Assert.That(kata.Revamp("batman is bruce wayne"), Is.EqualTo("is bceru aenwy aabmnt"));

        Assert.That(kata.Revamp("peter parker is spiderman"), Is.EqualTo("is eeprt aekprr adeimnprs"));

        Assert.That(kata.Revamp("codewars is great"), Is.EqualTo("is aegrt acdeorsw"));

        Assert.That(kata.Revamp("airplanes in the night sky"), Is.EqualTo("in eht ksy ghint aaeilnprs"));
    }
}