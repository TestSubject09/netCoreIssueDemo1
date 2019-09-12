using Newtonsoft.Json;
using System;

namespace C
{
    public class ClassC
    {
        public string GetFooBar()
        {
            var fooBarObject = new { Foo = "foo", Bar = "bar" };
            return JsonConvert.SerializeObject(fooBarObject);
        }
    }
}
