using PdpB27_Darslar.Lesson9_Tuple_Nullable;

namespace PdpB27_Darslar.Collections
{
    internal class ListNode:IDisposable
    {
        public int val;
        public ListNode? next;
        public ListNode? back;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
        public ListNode()
        {
            Console.WriteLine("ListNode()");
        }
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
