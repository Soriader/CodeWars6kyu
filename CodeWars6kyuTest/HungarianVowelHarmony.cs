namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class HungarianVowelHarmony
{
    public static string[,] Tests = new string [,] {
        // {input, expected},
        {"ablak", "ablakkal"},
        {"betű", "betűvel"},
        {"fa", "fával"},
        {"gonosz", "gonosszal"},
        {"kar", "karral"},
        {"keret", "kerettel"},
        {"kosz", "kosszal"},
        {"otthon", "otthonnal"},
        {"rokkant", "rokkanttal"},
        {"rács", "ráccsal"},
        {"szék", "székkel"},
        {"teve", "tevével"},
        {"tükör", "tükörrel"},
        {"virág", "virággal"},
    };

    [Test]
    public void HungarianVowelHarmonyTest()
    {
        for(int i=0; i < Tests.GetLength(0); i++) {
            var input = Tests[i,0];
            var actual = HungarianVowelHarmonyTask.Instrumental(input);
            var expected = Tests[i,1];
            Console.WriteLine("{0} -> {1}", input, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}