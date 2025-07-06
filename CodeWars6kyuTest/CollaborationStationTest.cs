namespace CodeWars6kyuTest;

public class CollaborationStationTest
{
    [Test]
    public void CollaborationStation()
    {
        string[] expected = new string[] {
            "I--h--k--o--a-- --l--e--",
            "- --i-- --u--r--a-- --x-",
            "--t--n--y-- --e--l--s--y"
        };
        string message = "I think you are all sexy";
        
        Assert.AreEqual(expected, CollaborationStationTask.SplitMessage(message, 3));
        
    }
}