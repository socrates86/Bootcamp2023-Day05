namespace Example2;

class Program
{
    static void Main(string[] args)
    {
        int number = 352;

        if(number % 2 == 0)
        {
            Console.WriteLine($"Number { number } is an even number");
        }
        else
        {
            Console.WriteLine($"number { number } is not an even number");
        }
    }
}