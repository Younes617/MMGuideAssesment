using System;
using System.Collections.Generic;
using System.Text;

namespace MMGuideAssesment1
{
    public class GenericList
    {
        public void DoSomething(object obj)
        {
            string objectType = obj.GetType() == typeof(Double) ? "Number" : obj.GetType().Name;
            Console.WriteLine("Foo " + objectType);
        }
    }
}
