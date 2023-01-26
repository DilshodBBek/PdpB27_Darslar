using PdpB27_Darslar.Collections;
using System.Runtime.CompilerServices;

namespace PdpB27_Darslar.Lesson7.Collections
{
    internal class LinkedListExamples
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;
            ListNode tmp = head;
            ListNode res = new ListNode();

            while (head.next != null)
            {
                while (tmp.next.next != null)
                {
                    tmp = tmp.next;
                }
                AddResult(tmp.next);
                tmp.next = null;
                tmp = head;
            }
            AddResult(head);
            //res = res.next;

            return res.next;

            void AddResult(ListNode tmp)
            {
                ListNode x = res;
                while (x.next != null)
                {
                    x = x.next;
                }
                x.next = tmp;
            }
        }

        public static void DoublyLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddLast(3);
            //linkedList.Count();
            //LinkedListNode<int> listNode = new LinkedListNode<int>(2);

            //listNode = new LinkedListNode<int>(3);

            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

            ListNode head = new();
            ListNode FirstNode = new();
            ListNode SecondNode = new();
            ListNode ThirdNode = new();

            head.next = FirstNode;
            head.back = null;
            head.val = 2;


            FirstNode.next = SecondNode;
            FirstNode.back = head;
            FirstNode.val = 3;

            SecondNode.next = ThirdNode;
            SecondNode.back = FirstNode;
            SecondNode.val = 4;

            ThirdNode.next = head;
            ThirdNode.back = SecondNode;
            ThirdNode.val = 5;
            ListNode head1 = head;

            while (head1.next != null)
            {
                Console.WriteLine(head1.val);
                head1 = head1.next;
                if (head == head1)
                {
                    break;
                }
            }
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode res = new();
            ListNode resHead = res;

            while (l1 != null || l2 != null) 
            {
                if (l1 == null)
                {
                    while (l2 != null)
                    {
                        res.next = l2;
                        l2 = l2.next;
                        res = res.next;
                    }
                }
                else if (l2 == null) 
                {
                    while (l1 != null)
                    {
                        res.next = l1;
                        l1 = l1.next;
                        res = res.next;
                    }
                }
                else if (l1.val>l2.val)
                {
                    res.next = l2;
                    l2 = l2.next;
                    res = res.next;
                }
                else
                {
                    res.next = l1;
                    l1 = l1.next;
                    res = res.next;
                }
                
            }


            return resHead.next;
            
        }
    }
}
