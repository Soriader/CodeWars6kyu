namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class ComGovOrgFirst
{
    [Test]
    public void SimpleTests()
    {    
        var source = new[] {
            "http://www.google.en/?x=jsdfkj",
            "http://www.google.de/?x=jsdfkj",
            "http://www.google.com/?x=jsdfkj",
            "http://www.google.com/?x=jsdfkj",
            "http://www.google.org/?x=jsdfkj",
            "http://www.google.gov/?x=jsdfkj",
            "http://www.google.acom/?x=jsdfkj",
            "http://www.google.govt/?x=jsdfkj",
        };
        var result = ComGovOrgFirstTask.OrderByDomain(source);

        //SortingTaskUtils.AreDomainsEqual(result, source);
      
        /*
           should be sorted to [
             "http://www.google.com/?x=jsdfkj",
             "http://www.google.com/?x=jsdfkj",
             "http://www.google.acom/?x=jsdfkj",
             "http://www.google.gov/?x=jsdfkj",
             "http://www.google.govt/?x=jsdfkj",
             "http://www.google.org/?x=jsdfkj",
             "http://www.google.de/?x=jsdfkj",
             "http://www.google.en/?x=jsdfkj",
           ]
        */
    }
}