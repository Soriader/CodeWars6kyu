using CodeWars6kyu;

namespace CodeWars6kyuTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
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