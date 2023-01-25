using PdpB27_Darslar.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
