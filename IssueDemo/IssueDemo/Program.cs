using B;
using System;

namespace IssueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB instanceB = new ClassB();
            Console.WriteLine(instanceB.GetFooBarFromC());
        }
    }
}
