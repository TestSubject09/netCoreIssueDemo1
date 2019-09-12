using C;
using System;

namespace B
{
    public class ClassB
    {
        public string GetFooBarFromC()
        {
            ClassC instanceC = new ClassC();
            return instanceC.GetFooBar();
        }
    }
}
