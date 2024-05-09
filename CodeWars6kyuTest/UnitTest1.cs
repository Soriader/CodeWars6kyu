using CodeWars6kyu;

namespace CodeWars6kyuTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
            public class FrontTests
            {
                [Test]

                public void EncryptThisTest()
                {
                    Assert.AreEqual("72olle", EncryptThisTask.EncryptThis("Hello"));
                    Assert.AreEqual("103doo", EncryptThisTask.EncryptThis("good"));
                    Assert.AreEqual("87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri", EncryptThisTask.EncryptThis("Why can we not all be like that wise old bird"));
                }

                [Test]
                public void StreetFighterCharacterSelectionTest()
                {
                    var fighters = new string[][]
                    {
                        new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
                        new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
                    };
                    var moves = new string[] { "up", "left", "right", "left", "left" };
                    var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };

                    var moves2 = new string[] { };
                    var expected2 = new string[] { };

                    var moves3 = new string[] { "right", "right", "right", "right", "right", "right", "right", "right" };
                    var expected3 = new string[] { "E.Honda", "Blanka", "Guile", "Balrog", "Vega", "Ryu", "E.Honda", "Blanka" };


                    CollectionAssert.AreEqual(expected, StreetFighterCharacterSelectionTask.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
                    CollectionAssert.AreEqual(expected2, StreetFighterCharacterSelectionTask.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves2));
                    CollectionAssert.AreEqual(expected3, StreetFighterCharacterSelectionTask.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves3));

                }

                [Test]
                public void DeleteOccurrencesTest()
                {
                    var expected = new int[] { 20, 37, 21 };

                    var actual = DeleteOccurrencesTask.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

                    CollectionAssert.AreEqual(expected, actual);

                    var expected2 = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

                    var actual2 = DeleteOccurrencesTask.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

                    CollectionAssert.AreEqual(expected2, actual2);
                }

                [Test]
                public void DetectPangramTest()
                {
                    Assert.AreEqual(true, DetectPangramTask.IsPangram("The quick brown fox jumps over the lazy dog."));
                }

                [Test]
                public void BuyingACarTest()
                {
                    int[] r = new int[] { 0, 4000 };
                    Assert.AreEqual(r, BuyingACarTask.nbMonths(12000, 8000, 1000, 1.5));
                }

                [Test]
                public void HighestRankNumberInAnArrayTest()
                {
                    Assert.AreEqual(12, HighestRankNumberInAnArrayTask.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }));
                    Assert.AreEqual(3, HighestRankNumberInAnArrayTask.HighestRank(new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 }));
                }

                [Test]
                public void ConsonantValueTest()
                {
                    Assert.AreEqual(26, ConsonantValueTask.Solve("zodiac"));
                    Assert.AreEqual(80, ConsonantValueTask.Solve("chruschtschov"));
                    Assert.AreEqual(38, ConsonantValueTask.Solve("khrushchev"));
                    Assert.AreEqual(103, ConsonantValueTask.Solve("twelfthstreet"));
                }

                [Test]
                public void BuildTowerTest()
                {
                    Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", BuildTowerTask.TowerBuilder(1)));
                    Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", BuildTowerTask.TowerBuilder(2)));
                    Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTowerTask.TowerBuilder(3)));
                }

                [Test]
                public void TortoiseRacingTest()
                {
                    Assert.AreEqual(new int[] { 0, 32, 18 }, TortoiseRacingTask.Race(720, 850, 70));
                    Assert.AreEqual(new int[] { 3, 21, 49 }, TortoiseRacingTask.Race(80, 91, 37));
                    Assert.AreEqual(new int[] { 2, 0, 0 }, TortoiseRacingTask.Race(80, 100, 40));
                }

                [Test]
                public static void DataReverseTest()
                {
                    int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
                    int[] data2 = new int[32] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
                    Assert.AreEqual(data2, DataReverseTask.DataReverse(data1));

                    int[] data3 = new int[16] { 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
                    int[] data4 = new int[16] { 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0 };
                    Assert.AreEqual(data4, DataReverseTask.DataReverse(data3));
                }

                [Test]
                public void YourOrderPleaseTest()
                {
                    Assert.AreEqual("Thi1s is2 3a T4est", YourOrderPleaseTask.Order("is2 Thi1s T4est 3a"));
                    Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", YourOrderPleaseTask.Order("4of Fo1r pe6ople g3ood th5e the2"));
                    Assert.AreEqual("", YourOrderPleaseTask.Order(""));
                }

                [Test]
                public void TribonacciSequenceTest()
                {
                    Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, TribonacciSequenceTask.Tribonacci(new double[] { 1, 1, 1 }, 10));
                    Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, TribonacciSequenceTask.Tribonacci(new double[] { 0, 0, 1 }, 10));
                    Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, TribonacciSequenceTask.Tribonacci(new double[] { 0, 1, 1 }, 10));
                }

                [Test]
                public void MultiplicationTableTest()
                {
                    int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
                    Assert.AreEqual(expected, MultiplicationTableTask.MultiplicationTable(3));
                }

                [Test]
                public void PersistentBuggerTest()
                {
                    Assert.AreEqual(3, PersistentBuggerTask.Persistence(39));
                    Assert.AreEqual(0, PersistentBuggerTask.Persistence(4));
                    Assert.AreEqual(2, PersistentBuggerTask.Persistence(25));
                    Assert.AreEqual(4, PersistentBuggerTask.Persistence(999));
                }

                [Test]
                public void FindTheUniqueNumberTest()
                {
                    Assert.AreEqual(1, FindTheUniqueNumberTask.GetUnique(new[] { 1, 2, 2, 2 }));
                    Assert.AreEqual(-2, FindTheUniqueNumberTask.GetUnique(new[] { -2, 2, 2, 2 }));
                    Assert.AreEqual(14, FindTheUniqueNumberTask.GetUnique(new[] { 11, 11, 14, 11, 11 }));

                }

                [Test]
                public void TheSupermarketQueueTest()
                {
                    Assert.AreEqual(5, TheSupermarketQueueTask.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100));
                    Assert.AreEqual(10, TheSupermarketQueueTask.QueueTime(new int[] { 1, 2, 3, 4 }, 1));
                    Assert.AreEqual(0, TheSupermarketQueueTask.QueueTime(new int[] { }, 1));
                    Assert.AreEqual(9, TheSupermarketQueueTask.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2));
                }


                [Test]
                public void BouncingBallsTest()
                {
                    Assert.AreEqual(3, BouncingBallsTask.bouncingBall(3.0, 0.66, 1.5));
                    Assert.AreEqual(15, BouncingBallsTask.bouncingBall(30.0, 0.66, 1.5));

                }

                [Test]
                public void SortTheOddTest()
                {
                    Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, SortTheOddTask.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
                    Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, SortTheOddTask.SortArray(new int[] { 5, 3, 1, 8, 0 }));
                    Assert.AreEqual(new int[] { }, SortTheOddTask.SortArray(new int[] { }));
                }

                [Test]
                public void TwoSumTest()
                {
                    Assert.AreEqual(new[] { 0, 2 }, TwoSumTask.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());
                    Assert.AreEqual(new[] { 1, 2 }, TwoSumTask.TwoSum(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray());
                    Assert.AreEqual(new[] { 0, 1 }, TwoSumTask.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray());
                }

                [Test]
                public void MexicanWaveTest()
                {
                    Assert.AreEqual(new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" }, MexicanWaveTask.Wave("hello"));
                    Assert.AreEqual(new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" }, MexicanWaveTask.Wave("codewars"));
                    Assert.AreEqual(new List<string> { "Gap", "gAp", "gaP" }, MexicanWaveTask.Wave("gap"));

                }


                [Test]
                public void ArrayDiffTest()
                {
                    Assert.AreEqual(new int[] { 2 }, ArrayDiffTask.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
                    Assert.AreEqual(new int[] { 2, 2 }, ArrayDiffTask.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
                    Assert.AreEqual(new int[] { 1 }, ArrayDiffTask.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
                    Assert.AreEqual(new int[] { 1, 2, 2 }, ArrayDiffTask.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
                    Assert.AreEqual(new int[] { }, ArrayDiffTask.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
                    Assert.AreEqual(new int[] { 3 }, ArrayDiffTask.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
                }
                [Test]
                public void FindTheOddIntTest()
                {
                    Assert.AreEqual(5, FindTheOddIntTask.FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
                }

                [Test]
                public void ExpandedNumberFormTest()
                {
                    Assert.That(ExpandedNumberFormTask.ExpandedForm(12), Is.EqualTo("10 + 2"));
                    Assert.That(ExpandedNumberFormTask.ExpandedForm(42), Is.EqualTo("40 + 2"));
                    Assert.That(ExpandedNumberFormTask.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
                }

                [Test]
                public void DuplicateEncoderTest()
                {
                    Assert.AreEqual("(((", DuplicateEncoderTask.DuplicateEncode("din"));
                    Assert.AreEqual("()()()", DuplicateEncoderTask.DuplicateEncode("recede"));
                    Assert.AreEqual(")())())", DuplicateEncoderTask.DuplicateEncode("Success"), "should ignore case");
                    Assert.AreEqual("))((", DuplicateEncoderTask.DuplicateEncode("(( @"));
                }

                [Test]
                public void UniqueInOrderTest()
                {
                    Assert.AreEqual("ABCDAB", UniqueInOrderTask.UniqueInOrder("AAAABBBCCDAABBB"));
                }

                [Test]
                public void TakeATenMinutesWalkTask()
                {
                    Assert.AreEqual(true, TakeATenMinutesWalkTest.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
                    Assert.AreEqual(false, TakeATenMinutesWalkTest.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
                    Assert.AreEqual(false, TakeATenMinutesWalkTest.IsValidWalk(new string[] { "w" }), "should return false");
                    Assert.AreEqual(false, TakeATenMinutesWalkTest.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
                }

                [Test]
                public void ConsecutiveStringsTest()
                {
                    Assert.AreEqual("abigailtheta", ConsecutiveStringsTask.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
                    Assert.AreEqual("oocccffuucccjjjkkkjyyyeehh", ConsecutiveStringsTask.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1));
                    Assert.AreEqual("", ConsecutiveStringsTask.LongestConsec(new String[] { }, 3));
                    Assert.AreEqual("ixoyx3452zzzzzzzzzzzz", ConsecutiveStringsTask.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3));
                }

                [Test]
                public void DuplicateCountTest()
                {
                    Assert.AreEqual(0, DuplicateCountTask.DuplicateCount(""));
                    Assert.AreEqual(0, DuplicateCountTask.DuplicateCount("abcde"));
                    Assert.AreEqual(2, DuplicateCountTask.DuplicateCount("aabbcde"));
                    Assert.AreEqual(2, DuplicateCountTask.DuplicateCount("aabBcde"), "should ignore case");
                    Assert.AreEqual(1, DuplicateCountTask.DuplicateCount("Indivisibility"));
                    Assert.AreEqual(2, DuplicateCountTask.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
                }


                [Test]
                public void AlphabetPositionTask()
                {
                    Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", AlphabetPositionTest.AlphabetPosition("The sunset sets at twelve o' clock."));
                    Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", AlphabetPositionTest.AlphabetPosition("The narwhal bacons at midnight."));
                }

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
}