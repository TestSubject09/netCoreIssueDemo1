using Newtonsoft.Json;
using System;

namespace C
{
    internal class ClassC : IClassC
    {
        public string GetFooBar()
        {
            var fooBarObject = new { Foo = "foo", Bar = "bar" };
            return JsonConvert.SerializeObject(fooBarObject);
        }
    }
}
