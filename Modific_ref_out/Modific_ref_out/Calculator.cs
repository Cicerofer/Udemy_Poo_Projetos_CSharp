using System;
using System.Collections.Generic;
using System.Text;

namespace Modific_ref_out
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
