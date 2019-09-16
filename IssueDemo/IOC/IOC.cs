using B;
using C;
using System;

namespace IOC
{
    public class IOC
    {
        public static IClassB GetBService()
        {
            return B.Accessor.GetBInstance(GetCService());
        }
        public static IClassC GetCService()
        {
            return C.Accessor.GetCInstance();
        }
    }
}
