using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    class TestClass
    {

        private string login { get; } = "LoGiN";
        private int password { get; } = 123456789;

        public void PassWord()
        {
            Console.WriteLine($"{password}");
        }

        public void Login()
        {
            Console.WriteLine($"{login}");
        }

        public void Newclass()
        {
            var helloTest = new HelloTest();
            helloTest.Hello();
        }
    }
}