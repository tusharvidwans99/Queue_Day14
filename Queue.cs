using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Day14
{
    public class Queue<T>
    {

        LinkedList<T> queue;

        //Queue constructor is used to declare linked list
        public Queue()
        {
            this.queue = new LinkedList<T> ();
        }



        //enqueue method appends the data in form of linked list, @param data is a T type data which is added to list
        public void enqueue(T data)
        {
            queue.AddLast(data);
        }

        //dequeue method has ability to remove the last data, used popLast method from linked list for dequeue
        public void dequeue()
        {
            queue.RemoveFirst();
        }
    }
}
