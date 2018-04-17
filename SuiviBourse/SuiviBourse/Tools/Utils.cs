using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviBourse.Tools
{
    class Utils
    {
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
    }
}
