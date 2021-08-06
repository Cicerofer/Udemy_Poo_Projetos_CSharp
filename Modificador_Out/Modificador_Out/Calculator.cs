using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_Out
{
    class Calculator
    {

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
