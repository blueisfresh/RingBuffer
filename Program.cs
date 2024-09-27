namespace RingBuffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Null Werte im Int
            RingBuffer<string> ringbufferString = new RingBuffer<string>(5);

            Console.WriteLine("Strings\n");

            ringbufferString.Add("elias1");
            ringbufferString.Add("elias2");
            ringbufferString.Add("elias3");
            ringbufferString.Add("elias4");
            ringbufferString.Add("elias5");
            ringbufferString.Add("elias6");
            ringbufferString.Add("elias7");
            ringbufferString.Add("elias8");
            ringbufferString.Add("elias9");
            // ringbuffer.Add("elias10");

            Console.WriteLine("All The Values got added\n");

            Console.WriteLine(ringbufferString.ToString());

            Console.WriteLine($"\nThe used Size: {ringbufferString.UsedSize}\n");

            ringbufferString.Clear();

            Console.WriteLine("The ringbuffer got cleared \n");

            Console.WriteLine(ringbufferString.ToString());

            RingBuffer<int> ringbufferInt = new RingBuffer<int>(5);

            Console.WriteLine("\nInt\n");

            for(int i = 0; i < 7; i++)
            {
                ringbufferInt.Add(i);
            }

            Console.WriteLine("All The Values got added\n");

            Console.WriteLine(ringbufferInt.ToString());

            Console.WriteLine($"\nThe used Size: {ringbufferInt.UsedSize}\n");

            ringbufferInt.Clear();

            Console.WriteLine("The ringbuffer got cleared\n");
            
            Console.WriteLine(ringbufferInt.ToString());
        }
    }
}
