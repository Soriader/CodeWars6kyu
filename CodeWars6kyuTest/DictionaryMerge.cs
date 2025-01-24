using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class DictionaryMerge
{
    [Test]
    public void DictionaryMergeTest()
    {
        var original1 = new Dictionary<string, int> { { "A", 1 }, { "B", 2 }, { "C", 3 } };
        var original2 = new Dictionary<string, int> { { "A", 4 }, { "D", 5 } };

        var merged = DictionaryMergeTask.Merge(original1, original2);
        var expected = new Dictionary<string, int[]>
        {
            { "A", new[] { 1, 4 } },
            { "B", new[] { 2 } },
            { "C", new[] { 3 } },
            { "D", new[] { 5 } }
        };

        // Por�wnanie zawarto�ci
        Assert.AreEqual(expected.Keys, merged.Keys);
        foreach (var key in expected.Keys)
        {
            Assert.AreEqual(expected[key], merged[key]);
        }
    }
}