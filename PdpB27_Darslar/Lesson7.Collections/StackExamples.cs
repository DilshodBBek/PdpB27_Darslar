using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdpB27_Darslar.Lesson7.Collections
{
    public class MyStack
    {

        Queue<int> queue=new Queue<int>();
        public MyStack()
        {

        }

        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        public int Pop()
        {
            queue.Reverse();
            return queue.Dequeue();
        }

        public int Top()
        {
            queue.Reverse();
            return queue.Peek();
        }

        public bool Empty()
        {

            return queue.TryPeek(out int s);
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
