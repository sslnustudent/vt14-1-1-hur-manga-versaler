using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_1Versaler.Model
{
    public static class TextAnalyzer
    { 
        public static int GetNumberOfCapitals(string text)
        {
            int count = 0;
            foreach(char c in text)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}