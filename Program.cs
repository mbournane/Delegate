namespace Delegate;

class Program
{
    static void Main(string[] args)
    {
        ShowMoney rising = RisingEuro;
        rising(1500);

        rising = RisingDollars;
        rising(1500);
    }
    public delegate void ShowMoney(double rising);
    public static void RisingEuro(double rising)
    {
        Console.WriteLine(rising+" euros");
    }
    public static void RisingDollars(double rising)
    {
        Console.WriteLine(rising +" dollars");
    }
}
