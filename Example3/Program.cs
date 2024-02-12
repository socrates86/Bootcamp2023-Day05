namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        int age = 15;

        if (age <= 2)
        {
            Console.WriteLine("You're a baby");
        }
        else if (age >= 3 && age <=12)
        {
            Console.WriteLine("You're a child");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("you're a teenager");
        }
        else if (age >= 20 && age <= 30)
        {
            Console.WriteLine("You're a youth");
        }
        else if (age >= 31 && age <= 50)
        {
            Console.WriteLine("You're an adult");
        }
        else
        {
            Console.WriteLine("You're an elder-");
        }
    }
}