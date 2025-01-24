using CodeWars6kyu;

namespace CodeWars6kyuTest;

public class EliminationTournament
{
    [Test]
    public void EliminationTournamentTest() 
    {
        var rounds = EliminationTournamentTask.Tourney(new[] { 9, 5, 4, 7, 6, 3, 8 });

        Assert.AreEqual(4, rounds.Length);
    }
}