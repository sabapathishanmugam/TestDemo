class Program
{
    static void Main(string[] args)
    {
        string name = "Welcome";

        char[] eachChar = name.ToCharArray();
        foreach (char c in eachChar)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine(" ");
    }
}