
using AppHW2_Bits;

public class Program
{

    class Bits
    {
        public byte Value { get; private get; } = 0;

        public Bits(byte b)
        {
            this.Value = b;
        }
        public static implicit operator byte(Bits b) => b.Value;
        public static implicit operator long(Bits b) => b.Value;
        public static implicit operator int(Bits b) => b.Value;
        public static explicit operator Bits(byte b) => new Bits(b);
        public static explicit operator Bits(short b) => new Bits(b);
        public static explicit operator Bits(int b) => new Bits(b);
    }

    private static void Main()
    {
        var value = new bits(7);

        var a = "";
        try
        {
            for (int i = 0; i < 8; i++)
            {
                a += value.getbit(i) ? 1 : 0;
            }
            a = string.join("", a.reverse());

            console.writeline(a);
            console.writeline(value.getbit(5));

            value.setbit(false, 2);
            console.writeline(value.value);

        }

        catch (exception ex)
        {
            console.writeline(ex.tostring());
        }


        var bits = new Bits(20);
        byte b = bits;
        Console.WriteLine(b);

        b = 21;
        bits = (Bits)b;
        Console.WriteLine(bits.Value);


    }
}

