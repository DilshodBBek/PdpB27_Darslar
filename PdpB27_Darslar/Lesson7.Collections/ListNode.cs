namespace PdpB27_Darslar.Collections
{
    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode back;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        
    }
}
