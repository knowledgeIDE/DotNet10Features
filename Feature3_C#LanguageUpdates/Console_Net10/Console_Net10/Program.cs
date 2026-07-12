using Console_Net10;

class Program
{
    static void Main(string[] args)
    {
        string str = "Welcome to the channel";

        Console.WriteLine(str.IsPalindrome());
        Console.WriteLine(str.WordCount());
        
        Console.WriteLine(DateTime.GetTomorrow());
        Console.WriteLine(DateTime.GetYesterday());
        Console.ReadLine();
    }
}