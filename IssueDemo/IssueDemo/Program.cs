using B;
using System;

namespace IssueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IClassB _bService = IOC.IOC.GetBService();
            Console.WriteLine(_bService.GetFooBarFromC());
        }
    }
}
