using C;
using System;

namespace B
{
    internal class ClassB : IClassB
    {
        readonly IClassC _serviceC;
        public ClassB(IClassC serviceC)
        {
            _serviceC = serviceC;
        }
        public string GetFooBarFromC()
        {   
            return _serviceC.GetFooBar();
        }
    }
}
