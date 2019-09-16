using System;
using System.Collections.Generic;
using System.Text;

namespace C
{
    public static class Accessor
    {
        public static IClassC GetCInstance()
        {
            return new ClassC();
        }
    }
}
