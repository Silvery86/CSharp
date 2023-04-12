namespace Mang_BT1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of integers to sort: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter the integers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Before sorting:");
        PrintArray(numbers);

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("After sorting:");
        PrintArray(numbers);

        Console.ReadKey();
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

