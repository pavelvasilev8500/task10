using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class TypeInfo
    {
        public void Class()
        {
            var c = new Class();
            var type = Type.GetType("Reflection.Class");
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
