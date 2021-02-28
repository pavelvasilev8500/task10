using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    class Class : IInterfane
    {
        private string login { get; } = "LoGiN";
        private int password { get; } = 123456789;

        public void Password()
        {
            Console.WriteLine(password);
        }

        void IInterfane.Login()
        {
            Console.WriteLine(login);
        }

        public void H()
        {
            var hello = new HelloClass();
            hello.Hello();
        }
    }
}
