namespace Sandbox;

public class BitTools
{
    public static void PrintAsBinary(int n)
    {
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}
