
Console.Clear();
Console.WriteLine("Welcome to the Queue Program!");

public class Queue<T>
{
    private T[] queue;
    private int head = 0;
    private int tail = 0;
    private int size = 0;

    public Queue(int size)
    {
        this.size = size;
        this.queue = new T[size];
    }

    public void Enqueue(T item)
    {
        if tail>size
        {
            Console.WriteLine("Queue is full");
            return false;
        }

        queue[tail] = item;
        tail++;
    }
    public T Dequeue()
    {
        if head ==tail
        {
            Console.WriteLine("Queue is empty");
            return false;
        }
        T item = queue[head]
        head++;
        return item;
    }

}

