using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Refliction
{
    class TypeInfo<T> where T : class
    {
        public void Info(T input)
        {
            var type = typeof(T);
            var cons = type.GetConstructors();
            var prop = type.GetMethods(BindingFlags.Instance
                                | BindingFlags.Static
                                | BindingFlags.Public
                                | BindingFlags.NonPublic
                                | BindingFlags.DeclaredOnly);
            foreach (var p in prop)
            {
                Console.WriteLine(p.Name);
            }
            foreach (var co in cons)
            {
                Console.WriteLine(co.Name);
            }
        }
    }
}