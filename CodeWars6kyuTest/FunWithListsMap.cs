namespace CodeWars6kyuTest;

using CodeWars6kyu;

public class FunWithListsMap
{
    [Test]
    public void FunWithListsMapTest()
    {
        Assert.That(FunWithListsMapTask.Map<string, string>(null, x => x), Is.Null);

        TestMap(FunWithListsMapTask.Map<int, int>(new Node<int>(1, new Node<int>(2, new Node<int>(3))), n => n),
            new Node<int>(1, new Node<int>(2, new Node<int>(3))));
    }
        
    private static void TestMap<T>(Node<T> result, Node<T>expected)
    {
        Assert.That(ToList(result), Is.EqualTo(ToList(expected)));
    }
    
    private static List<Node<T>> ToList<T>(Node<T> head)
    {
        List<Node<T>> list = new List<Node<T>>();
        Node<T> next = head;
        while (next != null)
        {
            list.Add(next);
            next = next.next;
        }
        return list;
    }
}
