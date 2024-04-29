namespace _1_Delegates;

class Program
{
    static void Main(string[] args)
    {
        ShowMoney showAmount = GetAmount;
        Console.WriteLine(showAmount(100.50) + " €");
        Console.WriteLine(showAmount(100.50) + " $");
    }

    public delegate double ShowMoney(double amount);

    public static double GetAmount(double amount)
    {
        return amount;
    }

}

