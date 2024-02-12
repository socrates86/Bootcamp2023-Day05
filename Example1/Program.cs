namespace Example5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What are you up to?");
        Console.WriteLine("1. NetIncome processing \n2. TotalAsset processing");
        string? UserRsp = Console.ReadLine();

        if (UserRsp == "1")
        {
            ProcessNetIncome();
        }
        else
        {
            ProcessTotalAsset();
        }
    }
       
    private static void ProcessNetIncome()
    {
            Console.WriteLine("Please provide revenue");
            string? Revenue = Console.ReadLine();
            double revenue = Convert.ToDouble(Revenue);

            Console.WriteLine("Please provide expenses");
            string? Expenses = Console.ReadLine();
            double expenses = Convert.ToDouble(Expenses);

            double netIncome = NetIncome(revenue, expenses);

            Console.WriteLine($"NetIncome is { netIncome }");
    }

    private static void ProcessTotalAsset()
    {
            Console.WriteLine("Please provide liability value");
            string? Liabilities = Console.ReadLine();
            double liabilities = Convert.ToDouble(Liabilities);

            Console.WriteLine("Please provide equity value");
            string? Equity = Console.ReadLine();
            double equity = Convert.ToDouble(Equity);

            double result = TotalAsset(liabilities, equity);

            Console.WriteLine($"TotalAsset is { result }");
    }

    private static double TotalAsset(double liabilities, double equity)
    {
            double result = liabilities + equity;
            return result;
    }

    private static double NetIncome(double revenue, double expenses)
    {
            double answer = revenue - expenses;
            return answer;
    }
}