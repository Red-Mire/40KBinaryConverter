using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40KBinaryConverter
{
    internal class ConversionEngine
    {

        internal static byte[] ConvertStringToAsciiBytes(string inputString)
        {
            return Encoding.ASCII.GetBytes(inputString);
        }


    }
}
