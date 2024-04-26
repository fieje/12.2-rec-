using System;

public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int val = 0, ListNode next = null)
    {
        Value = val;
        Next = next;
    }
}

public class Solution
{
    public static void SplitList(ListNode head, out ListNode positiveList, out ListNode negativeList)
    {
        positiveList = null;
        negativeList = null;
        SplitListRecursive(head, out positiveList, out negativeList);
    }

    private static void SplitListRecursive(ListNode head, out ListNode positiveList, out ListNode negativeList)
    {
        if (head == null)
        {
            positiveList = null;
            negativeList = null;
            return;
        }

        SplitListRecursive(head.Next, out positiveList, out negativeList);

        if (head.Value >= 0)
        {
            positiveList = new ListNode(head.Value, positiveList);
        }
        else
        {
            negativeList = new ListNode(head.Value, negativeList);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.Next = new ListNode(-2);
        head.Next.Next = new ListNode(3);
        head.Next.Next.Next = new ListNode(-4);
        head.Next.Next.Next.Next = new ListNode(5);

        Console.WriteLine("Початковий список:");
        PrintList(head);
        Console.WriteLine();

        ListNode positiveList;
        ListNode negativeList;
        Solution.SplitList(head, out positiveList, out negativeList);

        Console.WriteLine("Позитивний список:");
        PrintList(positiveList);

        Console.WriteLine("Негативний список:");
        PrintList(negativeList);

        Console.ReadLine();
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Value + " ");
            head = head.Next;
        }
        Console.WriteLine();
    }
}
