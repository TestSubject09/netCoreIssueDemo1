using C;
using System;
using System.Collections.Generic;
using System.Text;

namespace B
{
    public static class Accessor
    {
        public static IClassB GetBInstance(IClassC cService)
        {
            return new ClassB(cService);
        }
    }
}
