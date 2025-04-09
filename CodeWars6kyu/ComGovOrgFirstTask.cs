namespace CodeWars6kyu;

public class ComGovOrgFirstTask
{
    public static IEnumerable<string> OrderByDomain(IEnumerable<string> source)
    {
        var priorityTlds = new List<string> { "com", "gov", "org" };

        var parsed = source
            .Select(uriStr => new
            {
                Uri = uriStr,
                Tld = new Uri(uriStr).Host.Split('.').Last()
            });

        var priorityGroup = parsed
            .Where(x => priorityTlds.Contains(x.Tld))
            .OrderBy(x => priorityTlds.IndexOf(x.Tld));

        var otherGroup = parsed
            .Where(x => !priorityTlds.Contains(x.Tld))
            .OrderBy(x => x.Tld);

        return priorityGroup
            .Concat(otherGroup)
            .Select(x => x.Uri);
    }
}
//https://www.codewars.com/kata/57f21fcd69e09cb0d2000088/train/csharp