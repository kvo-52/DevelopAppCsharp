
using AppHW2_Bits;

internal class Program
{
    private static void Main(string[] args)
    {
        var value = new Bits(7);

        var a = "";
        try
        {
            for (int i = 0; i < 8; i++)
            {
                a += value.GetBit(i) ? 1 : 0;
            }
            a = string.Join("", a.Reverse());

            Console.WriteLine(a);
            Console.WriteLine(value.GetBit(5));

            value.SetBit(false, 2);
            Console.WriteLine(value.Value);

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
         }
    }
}

