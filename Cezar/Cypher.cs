using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar
{
    public class Cypher
    {
        public static StringBuilder encode = new StringBuilder();
        public static StringBuilder decode = new StringBuilder();

        public static string Encode(string text, int n)
        {
            for (int i = 0; i < text.Length; i++)
            {
               Int32 lab =text[i] + n;
                encode.Append(Convert.ToChar(lab));
            }

            return encode.ToString();
        }


        public static string Decode(string text, int n)
        {
            for (int i = 0; i < text.Length; i++)
            {
                
                decode.Append(Convert.ToChar(encode[i] - n));
            }
            return decode.ToString();
        }






    }
}
