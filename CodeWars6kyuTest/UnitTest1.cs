using CodeWars6kyu;

namespace CodeWars6kyuTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {

            [Test]
            public void BreakCamelCaseTest()
            {
                Assert.AreEqual("camel Casing", BreakCamelCaseTask.BreakCamelCase("camelCasing"));
            }


            [Test]
            public void GenericTests()
            {
                Assert.AreEqual(3, FindEvenIndexTask.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
                Assert.AreEqual(1, FindEvenIndexTask.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
                Assert.AreEqual(-1, FindEvenIndexTask.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
                Assert.AreEqual(3, FindEvenIndexTask.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
            }

            [Test]
            public void SampleTest()
            {
                Assert.AreEqual("no one likes this", LikesTest.Likes(new string[0]));
                Assert.AreEqual("Peter likes this", LikesTest.Likes(new string[] { "Peter" }));
                Assert.AreEqual("Jacob and Alex like this", LikesTest.Likes(new string[] { "Jacob", "Alex" }));
                Assert.AreEqual("Max, John and Mark like this", LikesTest.Likes(new string[] { "Max", "John", "Mark" }));
                Assert.AreEqual("Alex, Jacob and 2 others like this", LikesTest.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
            }
        }
    }
}