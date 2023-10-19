using CsharpOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    public interface IFamily
    {
        Person this[int index] { get;}

        int Count { get; }


    }
}
