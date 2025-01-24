using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class RequiredDataI
{
    [Test]
    public void RequiredDataITest()
    {
        string AsString(object[] o)
        {
            if (o == null)
            {
                return "[null]";
            }
            return string.Join(",", o.Select(a => a.GetType().IsArray ? "[[" + string.Join(",", (int[])((object[])a)[0]) + "], " + (int)((object[])a)[1] + "]" : a));
        }

        Assert.That(AsString(RequiredDataITask.CountSel(new[] { -3, -2, -1, 3, 4, -5, -5, 5, -1, -5 })), Is.EqualTo(AsString(new object[] { 10, 7, 5, new object[] { new int[] { -5 }, 3 } })));
        Assert.That(AsString(RequiredDataITask.CountSel(new[] { 5, -1, 1, -1, -2, 5, 0, -2, -5, 3 })), Is.EqualTo(AsString(new object[] { 10, 7, 4, new object[] { new int[] { -2, -1, 5 }, 2 } })));
        Assert.That(AsString(RequiredDataITask.CountSel(new[] { -2, 4, 4, -2, -2, -1, 3, 5, -5, 5 })), Is.EqualTo(AsString(new object[] { 10, 6, 3, new object[] { new int[] { -2 }, 3 } })));
        Assert.That(AsString(RequiredDataITask.CountSel(new[] { 4, -5, 1, -5, 2, 4, -1, 4, -1, 1 })), Is.EqualTo(AsString(new object[] { 10, 5, 1, new object[] { new int[] { 4 }, 3 } })));
        Assert.That(AsString(RequiredDataITask.CountSel(new[] { 4, 4, 2, -3, 1, 4, 3, 2, 0, -5, 2, -2, -2, -5 })), Is.EqualTo(AsString(new object[] { 14, 8, 4, new object[] { new int[] { 2, 4 }, 3 } })));
    }
}