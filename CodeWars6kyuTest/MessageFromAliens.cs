using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class MessageFromAliens
{
    [Test]
    public void MessageFromAliensTest()
    {
        Assert.That(MessageFromAliensTask.Decode(@"]()]|_]]|_]][-]|-|]"), Is.EqualTo("hello"));
        Assert.That(MessageFromAliensTask.Decode("{|^{|{{|_{]3{"), Is.EqualTo("blip"));
        Assert.That(MessageFromAliensTask.Decode("..[-.|_.|^....().[-.|^.__..|)...|.|^.|_|..~|~._\\~.__...[-..|.|).."), Is.EqualTo("die stupid people"));
        Assert.That(MessageFromAliensTask.Decode("'''_\\~'|_|'()'|''('|'|_'[-'|)''__'_\\~'/<'()'()'|_'''__'|\\|'|''/\\'/?']3'__''/?'|_|''()'`/''"), Is.EqualTo("your brain looks delicious"));
        Assert.That(MessageFromAliensTask.Decode("}/\\}~|~}/\\}/<}__}|)}}}[-}~|~}/\\}(}|}|_}|^}|_|}|)}__}|)}}}|\\|}|}/=}__}()}}}~|~}__}`/}/?}}~|~}"), Is.EqualTo("try to find duplicated kata"));
    }
}