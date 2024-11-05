using CodeWars6kyu;
using System.Text;
using System.Collections;
using NUnit.Framework.Internal;
using System.Numerics;


namespace CodeWars6kyuTest
{
    public class Tests
    {
        [TestFixture]
        public class KataTest
        {
            public class Tests
            {
				[Test]
				public void _0_TankState()
				{
					IUnit tank = new Tank();

					Assert.AreEqual(true, tank.CanMove);
					Assert.AreEqual(5, tank.Damage);
				}

				[Test]
				public static void ARuleOfDivisibilityByTest()
				{
					static void testing(long actual, long expected)
					{
						Assert.AreEqual(expected, actual);
					}

					testing(ARuleOfDivisibilityByTask.Thirt(8529), 79);
					testing(ARuleOfDivisibilityByTask.Thirt(85299258), 31);
					testing(ARuleOfDivisibilityByTask.Thirt(5634), 57);
					testing(ARuleOfDivisibilityByTask.Thirt(1111111111), 71);
					testing(ARuleOfDivisibilityByTask.Thirt(987654321), 30);
				}

				[Test]
				public void PlentyOfFishIThePondTest()
				{
					PlentyOfFishIThePondTask game = new PlentyOfFishIThePondTask();
					string shoal = "151128241212192113722321331";
					Assert.AreEqual(5, game.Fish(shoal));
				}

				[Test]
				public void AlternatingSplitTest()
				{
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Encrypt("This is a test!", 0));
					Assert.AreEqual("hsi  etTi sats!", AlternatingSplitTask.Encrypt("This is a test!", 1));
					Assert.AreEqual("s eT ashi tist!", AlternatingSplitTask.Encrypt("This is a test!", 2));
					Assert.AreEqual(" Tah itse sits!", AlternatingSplitTask.Encrypt("This is a test!", 3));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Encrypt("This is a test!", 4));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Encrypt("This is a test!", -1));
					Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", AlternatingSplitTask.Encrypt("This kata is very interesting!", 1));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt("This is a test!", 0));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt("hsi  etTi sats!", 1));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt("s eT ashi tist!", 2));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt(" Tah itse sits!", 3));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt("This is a test!", 4));
					Assert.AreEqual("This is a test!", AlternatingSplitTask.Decrypt("This is a test!", -1));
					Assert.AreEqual("This kata is very interesting!", AlternatingSplitTask.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
					Assert.AreEqual("", AlternatingSplitTask.Encrypt("", 0));
					Assert.AreEqual("", AlternatingSplitTask.Decrypt("", 0));
					Assert.AreEqual(null, AlternatingSplitTask.Encrypt(null, 0));
					Assert.AreEqual(null, AlternatingSplitTask.Decrypt(null, 0));
				}
				[Test]
				public void TwinPrimeTest()
				{
					Assert.AreEqual(true, TwinPrimeTask.IsTwinPrime(5));
					Assert.AreEqual(false, TwinPrimeTask.IsTwinPrime(25));
					Assert.AreEqual(true, TwinPrimeTask.IsTwinPrime(11));
					Assert.AreEqual(false, TwinPrimeTask.IsTwinPrime(8));
					Assert.AreEqual(false, TwinPrimeTask.IsTwinPrime(1));
					Assert.AreEqual(true, TwinPrimeTask.IsTwinPrime(29));
					Assert.AreEqual(false, TwinPrimeTask.IsTwinPrime(14));
					Assert.AreEqual(true, TwinPrimeTask.IsTwinPrime(41));
				}

				[Test]
				public void KillerGarageDoorTest()
				{
					var actual = KillerGarageDoorTask.ProcessEvents("..P...O.....");
					Assert.AreEqual("001234321000", actual);
				}

				[Test]
				public void CountTheDaysTest()
				{
					CountTheDaysTask d = new CountTheDaysTask();
					Assert.AreEqual("The day is in the past!", d.CountDays(new DateTime(2016, 12, 2)));
					Assert.AreEqual("Today is the day!", d.CountDays(DateTime.Now));
				}

				[Test]
				public void CasinoChipsTest()
				{
					Assert.AreEqual(1, CasinoChipsTask.Solve(new int[] { 1, 1, 1 }));
					Assert.AreEqual(2, CasinoChipsTask.Solve(new int[] { 1, 2, 1 }));
					Assert.AreEqual(2, CasinoChipsTask.Solve(new int[] { 4, 1, 1 }));
					Assert.AreEqual(9, CasinoChipsTask.Solve(new int[] { 8, 2, 8 }));
					Assert.AreEqual(5, CasinoChipsTask.Solve(new int[] { 8, 1, 4 }));
					Assert.AreEqual(10, CasinoChipsTask.Solve(new int[] { 7, 4, 10 }));
					Assert.AreEqual(18, CasinoChipsTask.Solve(new int[] { 12, 12, 12 }));
					Assert.AreEqual(3, CasinoChipsTask.Solve(new int[] { 1, 23, 2 }));
				}

				[Test]
				public void ConvertIntegerToWhitespaceFormatTest()
				{
					string unbleach(string ws)
					{
						return ws.Replace(" ", "[space]").Replace("\t", "[tab]").Replace("\n", "[LF]");
					}

					Assert.AreEqual(unbleach(" \t\n"), unbleach(ConvertIntegerToWhitespaceFormatTask.WhitespaceNumber(1)));
					Assert.AreEqual(unbleach(" \n"), unbleach(ConvertIntegerToWhitespaceFormatTask.WhitespaceNumber(0)));
					Assert.AreEqual(unbleach("\t\t\n"), unbleach(ConvertIntegerToWhitespaceFormatTask.WhitespaceNumber(-1)));
					Assert.AreEqual(unbleach(" \t \n"), unbleach(ConvertIntegerToWhitespaceFormatTask.WhitespaceNumber(2)));
					Assert.AreEqual(unbleach("\t\t\t\n"), unbleach(ConvertIntegerToWhitespaceFormatTask.WhitespaceNumber(-3)));
				}

				[Test]
				public void ValidateMyPasswordTest()
				{
					Assert.AreEqual("VALID", ValidateMyPasswordTask.Validator("Username123"));
					Assert.AreEqual("INVALID", ValidateMyPasswordTask.Validator("Username"));
					Assert.AreEqual("INVALID", ValidateMyPasswordTask.Validator("123"));
					Assert.AreEqual("INVALID", ValidateMyPasswordTask.Validator("Username123!"));
					Assert.AreEqual("INVALID", ValidateMyPasswordTask.Validator("ThisPasswordIsTooLong1234"));
				}

				[Test]
				public void PointsInTheCircleTest()
				{
					Assert.AreEqual(5, PointsInTheCircleTask.PointsNumber(1));
					Assert.AreEqual(13, PointsInTheCircleTask.PointsNumber(2));
					Assert.AreEqual(29, PointsInTheCircleTask.PointsNumber(3));
					Assert.AreEqual(81, PointsInTheCircleTask.PointsNumber(5));
					Assert.AreEqual(3141549, PointsInTheCircleTask.PointsNumber(1000));
				}

				[Test]
				public void HiddenCubicNumbersTest()
				{
					string s = "0 9026315 -827&()"; // "0 0 Lucky"
					String r = "0 0 Lucky";
					Assert.AreEqual(r, HiddenCubicNumbersTask.IsSumOfCubes(s));
				}

				[Test]
				public static void DiseaseSpreadTest()
				{
					static void testing(long act, long exp)
					{
						long r = Math.Abs(act - exp);
						bool inrange = r <= 1;
						if (inrange == false)
						{
							string specifier = "#.0";
							Console.WriteLine("abs(actual - expected) must be <= 1 but was " + r.ToString(specifier));
						}
						Assert.AreEqual(true, inrange);
					}

					int tm = 18; int n = 432; int s0 = 1004; int i0 = 1; double b = 0.00209; double a = 0.51;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 420);
					tm = 12; n = 288; s0 = 1007; i0 = 2; b = 0.00206; a = 0.45;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 461);
					tm = 13; n = 312; s0 = 999; i0 = 1; b = 0.00221; a = 0.55;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 409);
					tm = 24; n = 576; s0 = 1005; i0 = 1; b = 0.00216; a = 0.45;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 474);
					tm = 24; n = 576; s0 = 982; i0 = 1; b = 0.00214; a = 0.44;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 460);
					tm = 20; n = 480; s0 = 1000; i0 = 1; b = 0.00199; a = 0.53;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 386);
					tm = 28; n = 672; s0 = 980; i0 = 1; b = 0.00198; a = 0.44;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 433);
					tm = 14; n = 336; s0 = 996; i0 = 2; b = 0.00206; a = 0.41;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 483);
					tm = 13; n = 312; s0 = 993; i0 = 2; b = 0.0021; a = 0.51;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 414);
					tm = 28; n = 672; s0 = 999; i0 = 1; b = 0.00197; a = 0.55;
					testing(DiseaseSpreadTask.Epidemic(tm, n, s0, i0, b, a), 368);
				}

				[Test]
				public void WorldBitsWarTest()
				{
					DoTest(new List<int> { 1, 5, 12 }, "odds win");
					DoTest(new List<int> { 7, -3, 20 }, "evens win");
					DoTest(new List<int> { 7, -3, -2, 6 }, "tie");
					DoTest(new List<int> { -3, -5 }, "evens win");
					DoTest(new List<int>(), "tie");
					
					static void DoTest(List<int> input, String expected)
					{
						String message = "for input: {" + String.Join(", ", input) + "}\n";
						String actual = WorldBitsWarTask.BitsWar(input);
						Assert.AreEqual(expected, actual, message);
					}

				}

				[Test]
				public static void ReachMeAndSumMyDigitsTest()
				{
					Assert.AreEqual(10, ReachMeAndSumMyDigitsTask.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 6));
					Assert.AreEqual(10, ReachMeAndSumMyDigitsTask.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 15));
					Assert.AreEqual(9, ReachMeAndSumMyDigitsTask.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 50));
					Assert.AreEqual(7, ReachMeAndSumMyDigitsTask.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 157));

				}

				[Test]
				public void StringTopsTest()
				{
					Assert.AreEqual(String.Empty, StringTopsTask.Tops(String.Empty));
					Assert.AreEqual("2", StringTopsTask.Tops("12"));
					Assert.AreEqual("3pgb", StringTopsTask.Tops("abcdefghijklmnopqrstuvwxyz12345"));
					Assert.AreEqual("M3pgb", StringTopsTask.Tops("abcdefghijklmnopqrstuvwxyz1236789ABCDEFGHIJKLMN"));
				}

				[Test]
				public void ThePlugboardTest()
				{
					var pb = new ThePlugboardTask("AB");
					Assert.AreEqual('B', pb.Process('A'), "A has to be translated to B with 'AB'");
					Assert.AreEqual('A', pb.Process('B'), "B has to be translated to A with 'AB'");
					Assert.AreEqual('C', pb.Process('C'), "C has to stay C with 'AB'");
				}

				[Test]
				public static void ReversingAProcessTest()
				{
					Assert.AreEqual("uogbucwnddunktsjfanzlurnyxmx", ReversingAProcessTask.Decode("1273409kuqhkoynvvknsdwljantzkpnmfgf"));
					Assert.AreEqual("mfmwhbpoudfujjozopaugcb", ReversingAProcessTask.Decode("1544749cdcizljymhdmvvypyjamowl"));
					Assert.AreEqual("Impossible to decode", ReversingAProcessTask.Decode("105860ymmgegeeiwaigsqkcaeguicc"));

				}

				[Test]
				public static void UpAndDownTest()
				{
					Assert.AreEqual("who RETAINING hit THAT a THE we TAKEN", UpAndDownTask.Arrange("who hit retaining The That a we taken"));
					Assert.AreEqual("i CAME on WERE up GRANDMOTHERS so", UpAndDownTask.Arrange("on I came up were so grandmothers"));
					Assert.AreEqual("way THE my WALL him THEM", UpAndDownTask.Arrange("way the my wall them him"));
					Assert.AreEqual("turn GREAT-AUNTS know AUNT a LOOK to BACK", UpAndDownTask.Arrange("turn know great-aunts aunt look A to back"));

				}

				[Test]
				public void StringsNumbersAndCalculationTest()
				{
					Assert.AreEqual("47", StringsNumbersAndCalculationTask.CalculateString(";$%§fsdfsd235??df/sdfgf5gh.000kk0000"));
					Assert.AreEqual("54929268", StringsNumbersAndCalculationTask.CalculateString("sdfsd23454sdf*2342"));
					Assert.AreEqual("-210908", StringsNumbersAndCalculationTask.CalculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
					Assert.AreEqual("234676", StringsNumbersAndCalculationTask.CalculateString("fsdfsd234.4554s4234df+sf234442"));
				}

				[Test]
				public void StringSubpatternRecognitionTest()
				{
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("a"));
					Assert.AreEqual(true, StringSubpatternRecognitionTask.HasSubpattern("aaaa"));
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("abcd"));
					Assert.AreEqual(true, StringSubpatternRecognitionTask.HasSubpattern("abababab"));
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("ababababa"));
					Assert.AreEqual(true, StringSubpatternRecognitionTask.HasSubpattern("123a123a123a"));
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("123A123a123a"));
					Assert.AreEqual(true, StringSubpatternRecognitionTask.HasSubpattern("abbaabbaabba"));
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("abbabbabba"));
					Assert.AreEqual(false, StringSubpatternRecognitionTask.HasSubpattern("abcdabcabcd"));
				}

				[Test]
				public void SortingByBitsTest()
                {
					Assert.AreEqual(new[] { 1, 8, 3, 3, 5, 6, 9, 7 }, SortingByBitsTask.SortByBit(new[] { 3, 8, 3, 6, 5, 7, 9, 1 }));
					Assert.AreEqual(new[] { 0, 2, 2, 4, 8, 8, 3, 5, 5, 6, 9, 7, 56 }, SortingByBitsTask.SortByBit(new[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 }));

				}

				[Test]
				public void BrakingWellTest()
				{
					Assert.AreEqual(311.83146449201496, BrakingWellTask.Dist(144, 0.3), 1e-2);
					Assert.AreEqual(92.12909477605366, BrakingWellTask.Dist(92, 0.5), 1e-2);
					Assert.AreEqual(435.94398509960854, BrakingWellTask.Dist(142, 0.2), 1e-2);
					Assert.AreEqual(207.8876429946766, BrakingWellTask.Dist(96, 0.2), 1e-2);
					Assert.AreEqual(153.79671564846308, BrakingWellTask.Speed(159, 0.8), 1e-2);
					Assert.AreEqual(147.91115701756493, BrakingWellTask.Speed(164, 0.7), 1e-2);
					Assert.AreEqual(142.14404997566152, BrakingWellTask.Speed(153, 0.7), 1e-2);
					Assert.AreEqual(113.64202099481099, BrakingWellTask.Speed(88, 0.9), 1e-2);
				}

				[Test]
				public void BowlingPinsTest()
				{
					BowlingPinsTask bowling = new BowlingPinsTask();
					int[] testArray = new int[] { 1, 2, 3 };
					Assert.AreEqual("I I I I\n I I I \n       \n       ", bowling.BowlingPins(testArray));

					testArray = new int[] { 3, 5, 9 };
					Assert.AreEqual("I I   I\n I   I \n  I    \n   I   ", bowling.BowlingPins(testArray));
				}

				[Test]
				public static void EasyBalanceCheckingTest()
				{
					static void dotest(string s, string exp)
					{
						Console.Write("s:\n" + s + "\n");
						string ans = EasyBalanceCheckingTask.Balance(s);
						Console.Write("ACTUAL:\n" + ans + "\n");
						Console.Write("EXPECT:\n" + exp + "\n");
						Console.Write("{0:D}\n", exp == ans);
						Assert.AreEqual(exp, ans);
						Console.WriteLine("-");
					}

					String b1 = "1000.00!=\n125 Market !=:125.45\n126 Hardware =34.95\n127 Video! 7.45\n128 Book   :14.32\n129 Gasoline ::16.10";
					String b1sol = "Original Balance: 1000.00\n125 Market 125.45 Balance 874.55\n126 Hardware 34.95 Balance 839.60\n127 Video 7.45 Balance 832.15\n128 Book 14.32 Balance 817.83\n129 Gasoline 16.10 Balance 801.73\nTotal expense  198.27\nAverage expense  39.65";
					dotest(b1, b1sol);

					String b2 = "1233.00\n125 Hardware;! 24.80?\n123 Flowers 93.50;\n127 Meat 120.90\n120 Picture 34.00\n124 Gasoline 11.00\n" +
								"123 Photos;! 71.40?\n122 Picture 93.50\n132 Tyres;! 19.00,?;\n129 Stamps; 13.60\n129 Fruits{} 17.60\n129 Market;! 128.00?\n121 Gasoline;! 13.60?";
					String b2sol = "Original Balance: 1233.00\n125 Hardware 24.80 Balance 1208.20\n123 Flowers 93.50 Balance 1114.70\n127 Meat 120.90 Balance 993.80\n120 Picture 34.00 Balance 959.80\n124 Gasoline 11.00 Balance 948.80\n123 Photos 71.40 Balance 877.40\n122 Picture 93.50 Balance 783.90\n132 Tyres 19.00 Balance 764.90\n129 Stamps 13.60 Balance 751.30\n129 Fruits 17.60 Balance 733.70\n129 Market 128.00 Balance 605.70\n121 Gasoline 13.60 Balance 592.10\nTotal expense  640.90\nAverage expense  53.41";
					dotest(b2, b2sol);


				}

				[Test]
				public void ErrorsHistogramTest()
				{
					Assert.AreEqual("u  3     ***\rw  4     ****\rx  6     ******\rz  6     ******",
									ErrorsHistogramTask.Hist("tpwaemuqxdmwqbqrjbeosjnejqorxdozsxnrgpgqkeihqwybzyymqeazfkyiucesxwutgszbenzvgxibxrlvmzihcb"));

					Assert.AreEqual("u  2     **\rw  1     *\rz  1     *",
									ErrorsHistogramTask.Hist("aaifzlnderpeurcuqjqeywdq"));

					Assert.AreEqual("u  4     ****\rw  3     ***\rx  4     ****\rz  4     ****",
									ErrorsHistogramTask.Hist("sjeneccyhrcpfvpujfaoaykqllteovskclebmzjeqepilxygdmzvdfmxbqdzubkzturnuqxsewrwgmdfwgdx"));

					Assert.AreEqual("u  1     *\rw  4     ****\rx  2     **\rz  1     *",
									ErrorsHistogramTask.Hist("bnxyytdtqrkeaswymiwbxnuydwthweyzny"));

					Assert.AreEqual("u  5     *****\rw  4     ****\rx  4     ****\rz  4     ****",
									ErrorsHistogramTask.Hist("ttopvdaxgwfpzjmomkwssytktaizqtsekfmfhrabidwaugioqyyzrxbugsusxkfdevmijqyprcoxfyjqwsutoutjgozyhsoytg"));
				}

				[Test]
				public void SortMyAnimalsTest()
				{
					var animals = new List<Animal>
	  {
		new Animal {Name = "Cat", NumberOfLegs = 4},
		new Animal {Name = "Snake", NumberOfLegs = 0},
		new Animal {Name = "Dog", NumberOfLegs = 4},
		new Animal {Name = "Pig", NumberOfLegs = 4},
		new Animal {Name = "Human", NumberOfLegs = 2},
		new Animal {Name = "Bird", NumberOfLegs = 2}
	  };
					var output = new AnimalSorter().Sort(animals);
					Assert.AreEqual(output[0].Name, "Snake");
					Assert.AreEqual(output[3].Name, "Cat");
				}

				[Test]
				public void ColorChoiceTest()
				{
					Assert.AreEqual(2, ColorChoiceTask.Checkchoose(6, 4));
					Assert.AreEqual(1, ColorChoiceTask.Checkchoose(4, 4));
					Assert.AreEqual(3, ColorChoiceTask.Checkchoose(35, 7));
					Assert.AreEqual(-1, ColorChoiceTask.Checkchoose(4, 2));
					Assert.AreEqual(-1, ColorChoiceTask.Checkchoose(36, 7));
				}
				[Test]
				public static void MovesInSquaredStringsTest()
				{
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.Rot, "fijuoo\nCqYVct\nDrPmMJ\nerfpBA\nkWjFUG\nCVUfyL"),
							"LyfUVC\nGUFjWk\nABpfre\nJMmPrD\ntcVYqC\nooujif");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.Rot, "rkKv\ncofM\nzXkh\nflCB"),
							"BClf\nhkXz\nMfoc\nvKkr");

					Console.WriteLine("Fixed Tests SelfieAndRot");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.SelfieAndRot, "xZBV\njsbS\nJcpN\nfVnP"),
							"xZBV....\njsbS....\nJcpN....\nfVnP....\n....PnVf\n....NpcJ\n....Sbsj\n....VBZx");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.SelfieAndRot, "uLcq\nJkuL\nYirX\nnwMB"),
							"uLcq....\nJkuL....\nYirX....\nnwMB....\n....BMwn\n....XriY\n....LukJ\n....qcLu");

					static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public void PositionsAverageTest()
				{
					Assert.AreEqual(26.6666666667, PositionsAverageTask.PosAverage("466960, 069060, 494940, 060069, 060090, 640009, 496464, 606900, 004000, 944096"), 1e-9);
					Assert.AreEqual(29.2592592593, PositionsAverageTask.PosAverage("444996, 699990, 666690, 096904, 600644, 640646, 606469, 409694, 666094, 606490"), 1e-9);
					Assert.AreEqual(100, PositionsAverageTask.PosAverage("4444444, 4444444, 4444444, 4444444, 4444444, 4444444, 4444444, 4444444"), 1e-9);
				}

				[Test]
				public void TheBookOfMormonTest()
				{
					Assert.AreEqual(0, TheBookOfMormonTask.Mormons(10, 3, 9));
					Assert.AreEqual(1, TheBookOfMormonTask.Mormons(40, 2, 120));
					Assert.AreEqual(2, TheBookOfMormonTask.Mormons(40, 2, 121));
					Assert.AreEqual(12, TheBookOfMormonTask.Mormons(20000, 2, 7000000000));
				}

				[Test]
				public void CalculateTheAreaOfARegularSidesPolygonInsideTest()
				{
					Assert.AreEqual(11.691, CalculateTheAreaOfARegularSidesPolygonInsideTask.AreaOfPolygonInsideCircle(3, 3));
					Assert.AreEqual(8, CalculateTheAreaOfARegularSidesPolygonInsideTask.AreaOfPolygonInsideCircle(2, 4));
					Assert.AreEqual(14.86, CalculateTheAreaOfARegularSidesPolygonInsideTask.AreaOfPolygonInsideCircle(2.5, 5));
				}

				[Test]
				public void NumberFormatTest()
				{
					StringAssert.AreEqualIgnoringCase("100,000", NumberFormatTask.NumberFormat(100000));
					StringAssert.AreEqualIgnoringCase("5,678,545", NumberFormatTask.NumberFormat(5678545));
					StringAssert.AreEqualIgnoringCase("-251,347,469", NumberFormatTask.NumberFormat(-251347469));
				}

				[Test]
				public void ClockInMirrorTest()
				{
					StringAssert.AreEqualIgnoringCase("06:35", ClockInMirrorTask.WhatIsTheTime("05:25"));
					StringAssert.AreEqualIgnoringCase("11:59", ClockInMirrorTask.WhatIsTheTime("12:01"));
					StringAssert.AreEqualIgnoringCase("12:02", ClockInMirrorTask.WhatIsTheTime("11:58"));
					StringAssert.AreEqualIgnoringCase("12:00", ClockInMirrorTask.WhatIsTheTime("12:00"));
					StringAssert.AreEqualIgnoringCase("02:00", ClockInMirrorTask.WhatIsTheTime("10:00"));
				}

				[Test]
				public void MostFrequentWeekdaysTest()
				{
					Assert.AreEqual(new[] { "Friday", "Saturday" }, MostFrequentWeekdaysTask.MostFrequentDays(2016));
					Assert.AreEqual(new[] { "Monday" }, MostFrequentWeekdaysTask.MostFrequentDays(1770));
					Assert.AreEqual(new[] { "Monday" }, MostFrequentWeekdaysTask.MostFrequentDays(2001));
					Assert.AreEqual(new[] { "Monday", "Tuesday" }, MostFrequentWeekdaysTask.MostFrequentDays(1968));
					Assert.AreEqual(new[] { "Saturday" }, MostFrequentWeekdaysTask.MostFrequentDays(1785));
					Assert.AreEqual(new[] { "Saturday" }, MostFrequentWeekdaysTask.MostFrequentDays(1910));
					Assert.AreEqual(new[] { "Saturday" }, MostFrequentWeekdaysTask.MostFrequentDays(2135));
					Assert.AreEqual(new[] { "Sunday" }, MostFrequentWeekdaysTask.MostFrequentDays(3043));
					Assert.AreEqual(new[] { "Sunday" }, MostFrequentWeekdaysTask.MostFrequentDays(3150));
					Assert.AreEqual(new[] { "Thursday" }, MostFrequentWeekdaysTask.MostFrequentDays(3361));
					Assert.AreEqual(new[] { "Tuesday" }, MostFrequentWeekdaysTask.MostFrequentDays(1901));
					Assert.AreEqual(new[] { "Tuesday" }, MostFrequentWeekdaysTask.MostFrequentDays(3230));
					Assert.AreEqual(new[] { "Wednesday" }, MostFrequentWeekdaysTask.MostFrequentDays(1794));
					Assert.AreEqual(new[] { "Wednesday" }, MostFrequentWeekdaysTask.MostFrequentDays(1986));

				}

				[Test]
				public void SumOfPrimeIndexedElementsTest()
				{
					Assert.AreEqual(0, SumOfPrimeIndexedElementsTask.Solve(new int[] { }));
					Assert.AreEqual(7, SumOfPrimeIndexedElementsTask.Solve(new int[] { 1, 2, 3, 4 }));
					Assert.AreEqual(13, SumOfPrimeIndexedElementsTask.Solve(new int[] { 1, 2, 3, 4, 5, 6 }));
					Assert.AreEqual(47, SumOfPrimeIndexedElementsTask.Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }));

				}

				[Test]
				public static void HowMuchTest()
				{
					Assert.AreEqual("[[M: 37 B: 5 C: 4][M: 100 B: 14 C: 11]]", HowMuchTask.Howmuch(1, 100));
					Assert.AreEqual("[]", HowMuchTask.Howmuch(2950, 2950));
				}

				[Test]
				public void BasicTest()
				{
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("z"));
					Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("****"));
					Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("z*dq*mw*pb*s"));
					Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("zdqmwpbs"));
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("zz*zzs"));
					Assert.AreEqual("Left side wins!", AlphabetWarTask.AlphabetWar("*wwwwww*z*"));
				}

			    [Test]
				public void FruitMachineTest()
				{
					FruitMachineTask kata = new FruitMachineTask();
					string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
					List<string[]> reels = new List<string[]> { reel, reel, reel };
					int[] spins = new int[] { 0, 0, 0 };
					Assert.AreEqual(100, kata.Fruit(reels, spins));
				}

				[Test]
				public static void ReducingByStepsTest()
				{
					static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
					static string Array2String(long[] list)
					{
						return "[" + string.Join(",", list) + "]";
					}

					long[] a = new long[] { 18, 69, -90, -78, 65, 40 };
					long[] r = new long[] { 18, 3, 3, 3, 1, 1 };
					long[] op = ReducingByStepsTask.OperArray(ReducingByStepsTask.gcdi, a, a[0]);
					testing(Array2String(op), Array2String(r));
					r = new long[] { 18, 414, 2070, 26910, 26910, 107640 };
					op = ReducingByStepsTask.OperArray(ReducingByStepsTask.lcmu, a, a[0]);
					testing(Array2String(op), Array2String(r));
					r = new long[] { 18, 87, -3, -81, -16, 24 };
					op = ReducingByStepsTask.OperArray(ReducingByStepsTask.som, a, 0);
					testing(Array2String(op), Array2String(r));
					r = new long[] { 18, 18, -90, -90, -90, -90 };
					op = ReducingByStepsTask.OperArray(ReducingByStepsTask.mini, a, a[0]);
					testing(Array2String(op), Array2String(r));
					r = new long[] { 18, 69, 69, 69, 69, 69 };
					op = ReducingByStepsTask.OperArray(ReducingByStepsTask.maxi, a, a[0]);
					testing(Array2String(op), Array2String(r));
				}

				[Test]
				public void TransformToPrimeTest()
				{
					Assert.AreEqual(1, TransformToPrimeTask.MinimumNumber(new int[] { 3, 1, 2 }));
					Assert.AreEqual(0, TransformToPrimeTask.MinimumNumber(new int[] { 5, 2 }));
					Assert.AreEqual(0, TransformToPrimeTask.MinimumNumber(new int[] { 1, 1, 1 }));
					Assert.AreEqual(5, TransformToPrimeTask.MinimumNumber(new int[] { 2, 12, 8, 4, 6 }));
					Assert.AreEqual(2, TransformToPrimeTask.MinimumNumber(new int[] { 50, 39, 49, 6, 17, 28 }));
				}

				[Test]
				public void FinishTest1()
				{

					 int[,] maze = new int[,] 
                     {  { 1, 1, 1, 1, 1, 1, 1 },
						{ 1, 0, 0, 0, 0, 0, 3 },
						{ 1, 0, 1, 0, 1, 0, 1 },
						{ 0, 0, 1, 0, 0, 0, 1 },
						{ 1, 0, 1, 0, 1, 0, 1 },
						{ 1, 0, 0, 0, 0, 0, 1 },
						{ 1, 2, 1, 0, 1, 0, 1 } 
                     };

					MazeRunnerTask test = new MazeRunnerTask();


					string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };
					string result = test.MazeRunner(maze, directions);
					Assert.AreEqual("Finish", result, "Should return: 'Finish'");


					string[] directions2 = new string[] { "N", "N", "N", "W", "W" };
					string result2 = test.MazeRunner(maze, directions2);
					Assert.AreEqual("Dead", result2, "Should return: 'Dead'");

					string[] directions3 = new string[] { "N", "E", "E", "E", "E" };
					string result3 = test.MazeRunner(maze, directions3);
					Assert.AreEqual("Lost", result3, "Should return: 'Lost'");
				}


				[Test]
				public static void TankTruckTest()
				{
					Assert.AreEqual(2940, TankTruckTask.TankVol(5, 7, 3848));
					Assert.AreEqual(907, TankTruckTask.TankVol(2, 7, 3848));
				}

				[Test]
				public void RoundByStepsTest()
				{
					Assert.AreEqual(4, RoundByStepsTask.Solution(4.2));
					Assert.AreEqual(4.5, RoundByStepsTask.Solution(4.4));
					Assert.AreEqual(4.5, RoundByStepsTask.Solution(4.6));
					Assert.AreEqual(5, RoundByStepsTask.Solution(4.8));
				}

				[Test]
				public void BinaryToTextASCIIConversionTest()
				{
					Assert.AreEqual("", BinaryToTextASCIIConversionTask.BinaryToString(""));
					Assert.AreEqual("Hello", BinaryToTextASCIIConversionTask.BinaryToString("0100100001100101011011000110110001101111"));
				}

				[Test]
				public void IPv4Toint32Test()
				{
					Assert.AreEqual(2149583361, IPv4Toint32Task.ToInt32("128.32.10.1"), "Incorrect answer for ip = \"128.32.10.1\"");
				}

				[Test]
                public void PlayingOnAChessboardTest()
				{
					Assert.AreEqual("[0]", PlayingOnAChessboardTask.Game(0));
					Assert.AreEqual("[1, 2]", PlayingOnAChessboardTask.Game(1));
					Assert.AreEqual("[32]", PlayingOnAChessboardTask.Game(8));
				}

				[Test]
				public void TheDeafRatsOfHamelinTest()
                {
					Assert.AreEqual(0, TheDeafRatsOfHamelinTask.CountDeafRats("~O~O~O~O P"));
					Assert.AreEqual(1, TheDeafRatsOfHamelinTask.CountDeafRats("P O~ O~ ~O O~"));
					Assert.AreEqual(2, TheDeafRatsOfHamelinTask.CountDeafRats("~O~O~O~OP~O~OO~"));
				}
				

				[Test]
				public void LongestPalindromeTest()
				{
					Assert.AreEqual(5, LongestPalindromeTask.GetLongestPalindrome("'12 21glg' value test"));

				}

				[Test]
				public void ClockyMcClockFaceTest()
				{
					Assert.AreEqual("12:00", ClockyMcClockFaceTask.WhatTimeIsIt(0));
					Assert.AreEqual("12:00", ClockyMcClockFaceTask.WhatTimeIsIt(360));
					Assert.AreEqual("03:00", ClockyMcClockFaceTask.WhatTimeIsIt(90));
					Assert.AreEqual("06:00", ClockyMcClockFaceTask.WhatTimeIsIt(180));
					Assert.AreEqual("09:00", ClockyMcClockFaceTask.WhatTimeIsIt(270));

				}

				[Test]
				public void PIApproximationTest()
				{
					ArrayList r = PIApproximationTask.iterPi(0.1);
					ArrayList c = new ArrayList { 10, 3.0418396189 };
					Assert.AreEqual(c, r);
				}

				[Test]
				public void SumTheTreeTest()
				{
					var root = new SumTheTreeTask(10, new SumTheTreeTask(1), new SumTheTreeTask(2));
					Assert.AreEqual(13, SumTheTreeTask.SumTree(root), "Sum of values for a simple tree should be 13.");

					var root2 = new SumTheTreeTask(11, new SumTheTreeTask(0), new SumTheTreeTask(0, null, new SumTheTreeTask(1)));
					Assert.AreEqual(12, SumTheTreeTask.SumTree(root2), "Sum of values for an unbalanced tree should be 12.");
				}

				[Test]
				public static void SalesmanTravelTest()
				{
					string ad = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432,"
	+ "54 Holy Grail Street Niagara Town ZP 32908,3200 Main Rd. Bern AE 56210,1 Gordon St. Atlanta RE 13000,"
	+ "10 Pussy Cat Rd. Chicago EX 34342,10 Gordon St. Atlanta RE 13000,58 Gordon Road Atlanta RE 13000,"
	+ "22 Tokyo Av. Tedmondville SW 43098,674 Paris bd. Abbeville AA 45521,10 Surta Alley Goodtown GG 30654,"
	+ "45 Holy Grail Al. Niagara Town ZP 32908,320 Main Al. Bern AE 56210,14 Gordon Park Atlanta RE 13000,"
	+ "100 Pussy Cat Rd. Chicago EX 34342,2 Gordon St. Atlanta RE 13000,5 Gordon Road Atlanta RE 13000,"
	+ "2200 Tokyo Av. Tedmondville SW 43098,67 Paris St. Abbeville AA 45521,11 Surta Avenue Goodtown GG 30654,"
	+ "45 Holy Grail Al. Niagara Town ZP 32918,320 Main Al. Bern AE 56215,14 Gordon Park Atlanta RE 13200,"
	+ "100 Pussy Cat Rd. Chicago EX 34345,2 Gordon St. Atlanta RE 13222,5 Gordon Road Atlanta RE 13001,"
	+ "2200 Tokyo Av. Tedmondville SW 43198,67 Paris St. Abbeville AA 45522,11 Surta Avenue Goodville GG 30655,"
	+ "2222 Tokyo Av. Tedmondville SW 43198,670 Paris St. Abbeville AA 45522,114 Surta Avenue Goodville GG 30655,"
	+ "2 Holy Grail Street Niagara Town ZP 32908,3 Main Rd. Bern AE 56210,77 Gordon St. Atlanta RE 13000";

					testing(SalesmanTravelTask.Travel(ad, "AA 45522"), "AA 45522:Paris St. Abbeville,Paris St. Abbeville/67,670");
					testing(SalesmanTravelTask.Travel(ad, "EX 34342"), "EX 34342:Pussy Cat Rd. Chicago,Pussy Cat Rd. Chicago/10,100");
					testing(SalesmanTravelTask.Travel(ad, "EX 34345"), "EX 34345:Pussy Cat Rd. Chicago/100");
					testing(SalesmanTravelTask.Travel(ad, "AA 45521"), "AA 45521:Paris bd. Abbeville,Paris St. Abbeville/674,67");
					testing(SalesmanTravelTask.Travel(ad, "AE 56215"), "AE 56215:Main Al. Bern/320");

					static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public static void BallUpwardsTest()
				{
					testing(BallUpwardsTask.MaxBall(37), 10);
					testing(BallUpwardsTask.MaxBall(45), 13);
					testing(BallUpwardsTask.MaxBall(99), 28);
					testing(BallUpwardsTask.MaxBall(85), 24);

					static void testing(int actual, int expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public void SampleTest1()
				{
					Assert.AreEqual(10, IntegerDepthTask.ComputeDepth(1));
					Assert.AreEqual(9, IntegerDepthTask.ComputeDepth(42));

				}

				[Test]
				public void LinkedListsLengthCountTaskLengthTest()
				{
					LinkedListsLengthCountTask list = LinkedListsLengthCountTask.BuildOneTwoThree();
					Assert.AreEqual(0, LinkedListsLengthCountTask.Length(null), "Length of null list should be zero.");
					Assert.AreEqual(1, LinkedListsLengthCountTask.Length(new LinkedListsLengthCountTask(99)), "Length of single node list should be one.");
					Assert.AreEqual(3, LinkedListsLengthCountTask.Length(list), "Length of the three node list should be three.");
				}
				[Test]
				public void LinkedListsLengthCountTaskCountTest()
				{
					LinkedListsLengthCountTask list = LinkedListsLengthCountTask.BuildOneTwoThree();
					Assert.AreEqual(1, LinkedListsLengthCountTask.Count(list, value => value == 1), "list should only contain one 1.");
					Assert.AreEqual(1, LinkedListsLengthCountTask.Count(list, value => value == 2), "list should only contain one 2.");
					Assert.AreEqual(1, LinkedListsLengthCountTask.Count(list, value => value == 3), "list should only contain one 3.");
					Assert.AreEqual(0, LinkedListsLengthCountTask.Count(list, value => value == 99), "list should return zero for integer not found in list.");
					Assert.AreEqual(0, LinkedListsLengthCountTask.Count(null, value => value == 1), "null list should always return count of zero.");

					Assert.AreEqual(2, LinkedListsLengthCountTask.Count(list, value => value % 2 != 0), "list should contain two odd numbers.");
					Assert.AreEqual(1, LinkedListsLengthCountTask.Count(list, value => value % 2 == 0), "list should contain one even number.");
				}

				[Test]
				public void HelpTheBooksellerTest()
				{
					string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
					String[] cd = new String[] { "A", "B" };
					Assert.AreEqual("(A : 200) - (B : 1140)", HelpTheBooksellerTask.StockSummary(art, cd));
				}

				[Test]
				public static void StepsInPrimesTest()
				{
					Assert.AreEqual(new long[] { 101, 103 }, StepsInPrimesTask.Step(2, 100, 110));
					Assert.AreEqual(new long[] { 103, 107 }, StepsInPrimesTask.Step(4, 100, 110));
					Assert.AreEqual(new long[] { 101, 107 }, StepsInPrimesTask.Step(6, 100, 110));
					Assert.AreEqual(new long[] { 359, 367 }, StepsInPrimesTask.Step(8, 300, 400));
					Assert.AreEqual(new long[] { 307, 317 }, StepsInPrimesTask.Step(10, 300, 400));
					Assert.AreEqual(null, StepsInPrimesTask.Step(11, 30000, 100000));
				}

				[Test]
				public void PlayingWithDigitsTest()
				{
					Assert.AreEqual(51, PlayingWithDigitsTask.digPow(46288, 3));
					Assert.AreEqual(1, PlayingWithDigitsTask.digPow(89, 1));
					Assert.AreEqual(-1, PlayingWithDigitsTask.digPow(92, 1));

				}

				[Test]
				public void TitleCaseTest()
				{
					Assert.AreEqual("The Quick Brown Fox", TitleCaseTask.TitleCase("the quick brown fox"));
				}

				[Test]
				public void NewCashierDoesNotKnowTest()
				{
					Assert.AreEqual("Burger Fries Fries Chicken Pizza Sandwich Milkshake Coke",
					NewCashierDoesNotKnowTask.GetOrder("pizzachickenfriesburgercokemilkshakefriessandwich"));

					Assert.AreEqual("Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke",
						NewCashierDoesNotKnowTask.GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"));
				}

				[Test]
                public void RemoveTheParenthesesTest()
                {
                    Assert.AreEqual("exampleexample", RemoveTheParenthesesTask.RemoveParentheses("example(unwanted thing)example"));
                    Assert.AreEqual("example  example", RemoveTheParenthesesTask.RemoveParentheses("example (unwanted thing) example"));
                    Assert.AreEqual("a e", RemoveTheParenthesesTask.RemoveParentheses("a (bc d)e"));
                    Assert.AreEqual("a", RemoveTheParenthesesTask.RemoveParentheses("a(b(c))"));
                    Assert.AreEqual("hello example  something", RemoveTheParenthesesTask.RemoveParentheses("hello example (words(more words) here) something"));
                    Assert.AreEqual("  ", RemoveTheParenthesesTask.RemoveParentheses("(first group) (second group) (third group)"));
                }

                [Test]
                public static void EurekaTest()
                {
                    static string Array2String(long[] list)
                    {
                        return "[" + string.Join(", ", list) + "]";
                    }

                    static void testing(long a, long b, long[] res)
                    {
                        Assert.AreEqual(Array2String(res), Array2String(EurekaTask.SumDigPow(a, b)));
                    }

                    testing(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    testing(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
                    testing(10, 100, new long[] { 89 });
                    testing(90, 100, new long[] { });
                    testing(90, 150, new long[] { 135 });
                    testing(50, 150, new long[] { 89, 135 });
                    testing(10, 150, new long[] { 89, 135 });

                }

                [Test]
                public void EnglishBeggarsTest()
                {
                    int[] test = { 1, 2, 3, 4, 5 };
                    int[] a1 = { 15 }, a2 = { 9, 6 }, a3 = { 5, 7, 3 }, a4 = { 1, 2, 3, 4, 5, 0 }, a5 = { };
                    Assert.AreEqual(a1, EnglishBeggarsTask.Beggars(test, 1));
                    Assert.AreEqual(a2, EnglishBeggarsTask.Beggars(test, 2));
                    Assert.AreEqual(a3, EnglishBeggarsTask.Beggars(test, 3));
                    Assert.AreEqual(a4, EnglishBeggarsTask.Beggars(test, 6));
                    Assert.AreEqual(a5, EnglishBeggarsTask.Beggars(test, 0));
                }

                [Test]
                public void ReverseOrRotateTest()
                {
                    Assert.AreEqual("23456771", ReverseOrRotateTask.RevRot("123456779", 8));
                    Assert.AreEqual("44668753", ReverseOrRotateTask.RevRot("66443875", 4));
                }

                [Test]
                public void ArrayDeepCountTest()
                {
                    Assert.AreEqual(7, ArrayDeepCountTask.DeepCount(new object[] { 1, 2, new object[] { 3, 4, new object[] { 5 } } }));
                    Assert.AreEqual(0, ArrayDeepCountTask.DeepCount(new object[] { }));
                }

                [Test]
                public static void RainfallTest()
                {

                static void assertFuzzyEquals(double act, double exp)
                {
                    bool inrange = Math.Abs(act - exp) <= 1e-2;
                    if (inrange == false)
                    {
                        Console.WriteLine("abs(actual - expected) must be <= 1e-2. Expected was " + exp + ", but got " + act);
                    }
                    Assert.AreEqual(true, inrange);
                }

                static void Test1()
                {
                        string data =
     "Rome:Jan 81.2,Feb 63.2,Mar 70.3,Apr 55.7,May 53.0,Jun 36.4,Jul 17.5,Aug 27.5,Sep 60.9,Oct 117.7,Nov 111.0,Dec 97.9" +
     "\n" +
     "London:Jan 48.0,Feb 38.9,Mar 39.9,Apr 42.2,May 47.3,Jun 52.1,Jul 59.5,Aug 57.2,Sep 55.4,Oct 62.0,Nov 59.0,Dec 52.9" +
     "\n" +
     "Paris:Jan 182.3,Feb 120.6,Mar 158.1,Apr 204.9,May 323.1,Jun 300.5,Jul 236.8,Aug 192.9,Sep 66.3,Oct 63.3,Nov 83.2,Dec 154.7" +
     "\n" +
     "NY:Jan 108.7,Feb 101.8,Mar 131.9,Apr 93.5,May 98.8,Jun 93.6,Jul 102.2,Aug 131.8,Sep 92.0,Oct 82.3,Nov 107.8,Dec 94.2" +
     "\n" +
     "Vancouver:Jan 145.7,Feb 121.4,Mar 102.3,Apr 69.2,May 55.8,Jun 47.1,Jul 31.3,Aug 37.0,Sep 59.6,Oct 116.3,Nov 154.6,Dec 171.5" +
     "\n" +
     "Sydney:Jan 103.4,Feb 111.0,Mar 131.3,Apr 129.7,May 123.0,Jun 129.2,Jul 102.8,Aug 80.3,Sep 69.3,Oct 82.6,Nov 81.4,Dec 78.2" +
     "\n" +
     "Bangkok:Jan 10.6,Feb 28.2,Mar 30.7,Apr 71.8,May 189.4,Jun 151.7,Jul 158.2,Aug 187.0,Sep 319.9,Oct 230.8,Nov 57.3,Dec 9.4" +
     "\n" +
     "Tokyo:Jan 49.9,Feb 71.5,Mar 106.4,Apr 129.2,May 144.0,Jun 176.0,Jul 135.6,Aug 148.5,Sep 216.4,Oct 194.1,Nov 95.6,Dec 54.4" +
     "\n" +
     "Beijing:Jan 3.9,Feb 4.7,Mar 8.2,Apr 18.4,May 33.0,Jun 78.1,Jul 224.3,Aug 170.0,Sep 58.4,Oct 18.0,Nov 9.3,Dec 2.7" +
     "\n" +
     "Lima:Jan 1.2,Feb 0.9,Mar 0.7,Apr 0.4,May 0.6,Jun 1.8,Jul 4.4,Aug 3.1,Sep 3.3,Oct 1.7,Nov 0.5,Dec 0.7";

                    assertFuzzyEquals(RainfallTask.Mean("London", data), 51.199999999999996);
                    assertFuzzyEquals(RainfallTask.Mean("Beijing", data), 52.416666666666664);
                }


            } 

                [Test]
                public static void PrizeDrawTest()
                {
                    string st = "";
                    int[] we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
                    Assert.AreEqual("No participants", PrizeDrawTask.NthRank(st, we, 4));

                    st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
                    we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
                    Assert.AreEqual("Not enough participants", PrizeDrawTask.NthRank(st, we, 8));

                    st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
                    we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
                    Assert.AreEqual("Benjamin", PrizeDrawTask.NthRank(st, we, 4));

                    st = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
                    we = new int[] { 1, 3, 5, 5, 3, 6 };
                    Assert.AreEqual("Matthew", PrizeDrawTask.NthRank(st, we, 2));
                }

                [Test]
                public void ExtractPortionOfFileNameTest()
                {
                    Assert.AreEqual("FILE_NAME.EXTENSION", ExtractPortionOfFileNameTask.ExtractFileName("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"));
                    Assert.AreEqual("FILE_NAME.EXTENSION", ExtractPortionOfFileNameTask.ExtractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"));
                }

                [Test]
                public void FibonacciTribonacciAndFriendsTest()
                {
                    Assert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, FibonacciTribonacciAndFriendsTask.Xbonacci(new double[] { 0, 1 }, 10));
                    Assert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, FibonacciTribonacciAndFriendsTask.Xbonacci(new double[] { 1, 1 }, 10));
                    Assert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }, FibonacciTribonacciAndFriendsTask.Xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
                    Assert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }, FibonacciTribonacciAndFriendsTask.Xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));
                }

                [Test]
                public static void CountCharactersInYourStringTest()
                {
                    //assign
                    Dictionary<char, int> expectedResult = new();
                    expectedResult.Add('a', 2);
                    expectedResult.Add('b', 1);
                    //act
                    var result = CountCharactersInYourStringTask.Count("aba");
                    //assert
                    Assert.AreEqual(expectedResult, result);

                }

                [Test]
                public static void MeetingTest()
                {
                    static void testing(string s, string expect)
                    {
                        string actual = MeetingTask.Meeting(s);
                        Assert.AreEqual(expect, actual);
                    }

                    testing("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill",
                        "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)");

                    testing("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:Stan;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn",
                        "(ARNO, ANN)(BELL, JOHN)(CORNWELL, ALEX)(DORNY, ABBA)(KERN, LEWIS)(KORN, ALEX)(META, GRACE)(SCHWARZ, VICTORIA)(STAN, MADISON)(STAN, MEGAN)(WAHL, ALEXIS)");

                    testing("John:Gates;Michael:Wahl;Megan:Bell;Paul:Dorries;James:Dorny;Lewis:Steve;Alex:Meta;Elizabeth:Russel;Anna:Korn;Ann:Kern;Amber:Cornwell",
                        "(BELL, MEGAN)(CORNWELL, AMBER)(DORNY, JAMES)(DORRIES, PAUL)(GATES, JOHN)(KERN, ANN)(KORN, ANNA)(META, ALEX)(RUSSEL, ELIZABETH)(STEVE, LEWIS)(WAHL, MICHAEL)");

                    testing("Alex:Arno;Alissa:Cornwell;Sarah:Bell;Andrew:Dorries;Ann:Kern;Haley:Arno;Paul:Dorny;Madison:Kern",
                        "(ARNO, ALEX)(ARNO, HALEY)(BELL, SARAH)(CORNWELL, ALISSA)(DORNY, PAUL)(DORRIES, ANDREW)(KERN, ANN)(KERN, MADISON)");
                }

                [Test]
                public void ArrayHelpersTest()
                {
                    CollectionAssert.AreEqual(new[] { 1, 4, 9, 16, 25 }, ArrayHelpersTask.Square(new[] { 1, 2, 3, 4, 5 }));
                    CollectionAssert.AreEqual(new[] { 1, 8, 27, 64, 125 }, ArrayHelpersTask.Cube(new[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(15, ArrayHelpersTask.Sum(new[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(3, ArrayHelpersTask.Average(new[] { 1, 2, 3, 4, 5 }));
                    CollectionAssert.AreEqual(new[] { 2, 4 }, ArrayHelpersTask.Even(new[] { 1, 2, 3, 4, 5 }));
                    CollectionAssert.AreEqual(new[] { 1, 3, 5 }, ArrayHelpersTask.Odd(new[] { 1, 2, 3, 4, 5 }));

                }

                [Test]
                public static void StatisticsForAnAthleticAssociationTest()
                {
                    Assert.AreEqual("Range: 01|01|18 Average: 01|38|05 Median: 01|32|34",
                            StatisticsForAnAthleticAssociationTask.Stat("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17"));
                    Assert.AreEqual("Range: 01|01|18 Average: 01|35|47 Median: 01|24|57",
                            StatisticsForAnAthleticAssociationTask.Stat("01|15|59, 01|17|20, 1|32|34, 2|17|17"));
                    Assert.AreEqual("Range: 00|31|17 Average: 02|26|18 Median: 02|22|00",
                        StatisticsForAnAthleticAssociationTask.Stat("02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41"));
                }

                [Test]
                public void AreTheyTheSameTest()
                {
                    int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
                    int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
                    bool r = AreTheyTheSameTask.Comp(a, b); 
                    Assert.AreEqual(true, r);
                }

                [Test]
                public void DecipherThisTest()
                {
                    Assert.AreEqual("", DecipherThisTask.DecipherThis(""));
                    Assert.AreEqual("A", DecipherThisTask.DecipherThis("65"));
                    Assert.AreEqual("Ab", DecipherThisTask.DecipherThis("65b"));
                    Assert.AreEqual("Ready set go", DecipherThisTask.DecipherThis("82yade 115te 103o"));
                    Assert.AreEqual("Thank you Piotr for all your help", DecipherThisTask.DecipherThis("84kanh 121uo 80roti 102ro 97ll 121ruo 104ple"));
                    Assert.AreEqual("Why can we not all be like that wise old bird", DecipherThisTask.DecipherThis("87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri"));
                    Assert.AreEqual("Have a go at this and see how you do", DecipherThisTask.DecipherThis("72eva 97 103o 97t 116sih 97dn 115ee 104wo 121uo 100o"));
                }

                [Test]
                public void CountTheSmileyFacesTest()
                {
                    Assert.AreEqual(4, CountTheSmileyFacesTask.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
                    Assert.AreEqual(2, CountTheSmileyFacesTask.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
                    Assert.AreEqual(1, CountTheSmileyFacesTask.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
                    Assert.AreEqual(0, CountTheSmileyFacesTask.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
                }

                [Test]
                public void BuildAPileOfCubesTest()
                {
                    Assert.AreEqual(2022, BuildAPileOfCubesTask.findNb(4183059834009));
                    Assert.AreEqual(-1, BuildAPileOfCubesTask.findNb(24723578342962));
                    Assert.AreEqual(3568, BuildAPileOfCubesTask.findNb(40539911473216));
                    Assert.AreEqual(4824, BuildAPileOfCubesTask.findNb(135440716410000));
                }

                [Test]
                public void WordToa10nTest()
                {
                    Assert.AreEqual("i18n", WordToa10nTask.Abbreviate("internationalization"));
                    Assert.AreEqual("my. dog, isn't f5g v2y w2l.", WordToa10nTask.Abbreviate("my. dog, isn't feeling very well."));

                }

                [Test]
                public void AddOneArrayTest()
                {
                    var num1 = new int[] { 2, 3, 9 };
                    var newNum1 = new int[] { 2, 4, 0 };
                    Assert.AreEqual(newNum1, AddOneArrayTask.UpArray(num1));

                    var num2 = new int[] { 4, 3, 2, 5 };
                    var newNum2 = new int[] { 4, 3, 2, 6 };
                    Assert.AreEqual(newNum2, AddOneArrayTask.UpArray(num2));

                    var num3 = new int[] { 9, 9 };
                    var newNum3 = new int[] { 1, 0, 0 };
                    Assert.AreEqual(newNum3, AddOneArrayTask.UpArray(num3));

                    var num4 = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1 };
                    var newNum4 = new int[] { 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2 };
                    Assert.AreEqual(newNum4, AddOneArrayTask.UpArray(num4));
                }

                [Test]
                public void GiveMeADiamondTest()
                {
                    var expected = new StringBuilder();
                    expected.Append("  *\n");
                    expected.Append(" ***\n");
                    expected.Append("*****\n");
                    expected.Append(" ***\n");
                    expected.Append("  *\n");

                    Assert.AreEqual(expected.ToString(), GiveMeADiamondTask.Print(5));
                }

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