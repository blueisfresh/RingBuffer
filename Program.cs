namespace RingBuffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test mit Strings
            RingBuffer<string> ringBufferString = new RingBuffer<string>(5);

            Console.WriteLine("==== String RingBuffer Test ====\n");

            // Hinzufügen von Werten zum Ringbuffer
            for (int i = 1; i <= 9; i++)
            {
                ringBufferString.Add($"elias{i}");
            }

            Console.WriteLine("Alle String-Werte wurden hinzugefügt.");
            Console.WriteLine("\nInhalt des RingBuffers:");
            Console.WriteLine(ringBufferString.ToString());
            Console.WriteLine($"Genutzte Größe: {ringBufferString.UsedSize}\n");

            // Ringbuffer leeren
            ringBufferString.Clear();
            Console.WriteLine("Der String RingBuffer wurde geleert.");
            Console.WriteLine("\nInhalt des RingBuffers:");
            Console.WriteLine(ringBufferString.ToString());
            Console.WriteLine($"Genutzte Größe: {ringBufferString.UsedSize}\n");

            // Test mit Int-Werten
            RingBuffer<int> ringBufferInt = new RingBuffer<int>(5);

            Console.WriteLine("\n==== Integer RingBuffer Test ====\n");

            // Hinzufügen von Werten zum Ringbuffer
            for (int i = 0; i < 7; i++)
            {
                ringBufferInt.Add(i);
            }

            Console.WriteLine("Alle Integer-Werte wurden hinzugefügt.");
            Console.WriteLine("\nInhalt des RingBuffers:");
            Console.WriteLine(ringBufferInt.ToString());
            Console.WriteLine($"Genutzte Größe: {ringBufferInt.UsedSize}\n");

            // Ringbuffer leeren
            ringBufferInt.Clear();
            Console.WriteLine("Der Integer RingBuffer wurde geleert.");
            Console.WriteLine("\nInhalt des RingBuffers:");
            Console.WriteLine(ringBufferInt.ToString());
            Console.WriteLine($"Genutzte Größe: {ringBufferInt.UsedSize}\n");

        }
    }
}
