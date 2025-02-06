namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class CleverSplits
{
    [TestFixture]
    public class CleverSplitTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Buy a !car [!red green !white] [cheap or !new]").Returns(new string[] {"Buy", "a", "!car", "[!red green !white]", "[cheap or !new]"});
                yield return new TestCaseData("!Learning !C# is [a joy]").Returns(new string[] {"!Learning", "!C#", "is", "[a joy]"});
                yield return new TestCaseData("[Cats and dogs] are !beautiful and [cute]").Returns(new string[] {"[Cats and dogs]", "are", "!beautiful", "and", "[cute]"});
            }
        }
  
        [Test, TestCaseSource("testCases")]
        public string[] Test(string s) =>
            CleverSplitTask.CleverSplit(s);
    }
}