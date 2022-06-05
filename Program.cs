namespace Queue_Day14
{
    /// <summary>
    ///Use LinkedList to do the Queue Operations. 
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);

            queue.dequeue();
        }
    }
}