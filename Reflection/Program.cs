using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var typeInfo = new TypeInfo<TestClass>();
                var typeInfo1 = new TypeInfo<HelloTest>();
                typeInfo.Info(new TestClass());
                typeInfo1.Info(new HelloTest());
            }
        }
    }
}
