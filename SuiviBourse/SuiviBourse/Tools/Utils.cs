using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Tools
{
    class Utils
    {
       // @TODO faire ca avec du reghEx
        
        public static float ExtractFloat(String s, char c)
        {
            float res = 0;
            int i = s.IndexOf(c);
            if (i > 0)
            {
                res = (float)Convert.ToDouble(s.Substring(0, i));
            }
            return res;

        }
        public static float ExtractFloat(String s, char c1, char c2)
        {
            float res = 0;
            int i1 = s.IndexOf(c1);
            int i2 = s.IndexOf(c2);
            if (i1 >= 0  & i2> i1 )
            {
                res = (float)Convert.ToDouble(s.Substring(i1+1, i2-i1-1));
            }
            return res;

        }
    }
}
