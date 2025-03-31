
namespace CodeWars6kyu;

public class FunWithListsMapTask
{
    public static Node<T2> Map<T, T2>(Node<T> head, Func<T, T2> f) 
    {
        if (head == null)
        {
            return null;
        }
        
        Node<T2> newHead = new Node<T2>(f(head.data));
        Node<T2> currentNew = newHead;
        Node<T> currentOriginal = head.next;
        
        while (currentOriginal != null)
        {
            currentNew.next = new Node<T2>(f(currentOriginal.data));
            currentNew = currentNew.next;
            currentOriginal = currentOriginal.next;
        }
        
        return newHead;
    }
}

public class Node<T>
{
    public T data;
    public Node<T> next;

    public Node(T data)  
    {
        this.data = data;
    }

    public Node(T data, Node<T> next) 
    {
        this.data = data;
        this.next = next;
    }
}
//https://www.codewars.com/kata/58259d9062cfb45e1a00006b/train/csharp