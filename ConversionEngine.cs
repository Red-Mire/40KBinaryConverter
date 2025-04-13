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

        internal static string ConvertAsciiBytesToBinary(byte[] inputBytes)
        {
            string conversion = "";
            
            foreach (byte b in inputBytes)
            {
                string convertedByte = Convert.ToString(b, 2).PadLeft(8, '0');
                conversion = conversion + convertedByte;
            }
            
            return conversion;

        }

    }
}
