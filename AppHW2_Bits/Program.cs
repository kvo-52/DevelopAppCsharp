
using AppHW2_Bits;

public class Program
{

    static void Main()
    {
        long lValue = 64;
        int iValue = 128;
        byte bValue = 128;

        Bits bitsFromLong = lValue;
        Bits bitsFromInt = iValue;
        Bits bitsFromByte = (byte)bValue;

        Console.WriteLine(bitsFromLong);
        Console.WriteLine(bitsFromInt);
        Console.WriteLine(bitsFromByte);

    }
}

