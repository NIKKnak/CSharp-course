using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{

    //Спроектируйте интерфейс для класса способного устанавливать и
    //получать  значения отдельных бит в  заданном числе. 
    // до 21:20

    }
    // реализовать интерфейс из прошлой задачи применив его к классу bits из
    // примера предыдущей лекции.

    public interface IBits
    {
        byte Value { get; set; }
        public bool GetBit(int i);
        public void SetBit(bool bit, int index);
    }
    public class IndexException : Exception
    {
        public IndexException(string messge) : base(messge) { }
    }
    public class Bits : IBits
    {
        public Bits(byte b)
        {
            this.Value = b;
        }

        public byte Value { get; set; } = 0;

        public bool this[int index]
        {
            get
            {
                if (index > 7 || index < 0)
                    return false;
                return ((Value >> index) & 1) == 1;
            }
            set
            {
                if (index > 7 || index < 0) return;
                if (value == true)
                    Value = (byte)(Value | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask = (byte)(0xff ^ mask);
                    Value &= (byte)(Value & mask);
                }
            }
        }


        public static implicit operator byte(Bits b) => b.Value;
        public static explicit operator Bits(byte b) => new Bits(b);

        public bool GetBit(int i)
        {
            if (i > 7 || i < 0)
            {
                throw new Exception("Значение бита дожнобыть в пределах от 0 до 8");
            }

            return ((Value >> i) & 1) == 1;
        }

        public void SetBit(bool bit, int index)
        {
            if (index > 7 || index < 0) return;
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



}
