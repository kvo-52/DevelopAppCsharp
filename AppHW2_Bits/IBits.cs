using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHW2_Bits
{
    internal interface IBits
    {
        bool GetBit(int i);
        void SetBit(bool bit, int index);

    }

    public class Bits : IBits
    {
        private ulong bits;


        public Bits(ulong bits)
        {
            this.bits = bits;
        }

        public static implicit operator Bits(long value)
        {
            return new Bits((ulong)value);
        }

        public static implicit operator Bits(int value)
        {
            return new Bits((ulong)value);
        }

        public static implicit operator Bits(byte value)
        {
            return new Bits((ulong)value);
        }

        public long Value { get; set; } = 0;
        private int MaxBitsCount { get; set; }

        public override string ToString()
        {
            return bits.ToString();
        }

        public bool GetBit(int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return false;
            }

            return ((Value >> index) & 1) == 1;
        }

        public void SetBit(bool bit, int index)
        {
            if (index > MaxBitsCount || index < 0)
            {
                Console.WriteLine($"Выход за пределы от 0 до {MaxBitsCount}");
                return;
            }
            if (bit == true)
                Value = (byte)(Value | (1 << index));
            else
            {
                var mask = (byte)(1 << index);
                mask = (byte)(0xff ^ mask);
                Value &= (byte)(Value & mask);
            }


        }

                
    }
}

