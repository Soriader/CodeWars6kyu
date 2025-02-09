namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class StringSubpatternRecognitionII
{
    [Test]
    public void StringSubpatternRecognitionIITest()
    {
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("a"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("AA"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("444"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("aaaa"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("abcd"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("babababababababa"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("ababababa"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("123a123a123a"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("123A123a123a"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("12aa13a21233"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("12aa13a21233A"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("abcdabcaccd"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("aaaabb"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("abbb"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("aabbbbbbaa"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("bbabbaaabbaaaabb"), Is.EqualTo(true));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("aaabbbccccdddddd"), Is.EqualTo(false));
        Assert.That(StringSubpatternRecognitionIITask.HasSubpattern("aaabbbccccdddddddd"), Is.EqualTo(false));
    }
}