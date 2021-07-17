using System;
using System.Collections.Generic;
using System.Linq;

namespace Samples
{
    public static class TaskNumberFour
    {
        public static bool IsProperly(string sequence)
        {
            string strInput = sequence;
            int cnt = 0;
            foreach (char c in strInput)
                if (c == '(')
                    cnt++;
                else if (c == ')')
                    cnt--;

            if (cnt == 0)
                return true;
            else
                return false;
        }
    }
}