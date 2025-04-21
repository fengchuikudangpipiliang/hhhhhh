using System;
using System.Collections.Generic;
using System.Collections;

namespace hhhhhh
{
    delegate void  MyDel();
    internal class Program
    {
        static void Main()
        {
            MyEnumerableClass myClass = new MyEnumerableClass();
            foreach (var item in myClass)
            {
                Console.WriteLine(item);
            }
        }
    }
    class MyEnumerableClass
    {
        public IEnumerator<string> GetEnumerator()
        {
            return MyCoroutine();
        }
        IEnumerator<string> MyCoroutine()
        {
            yield return "hello";
            yield return ",";
            yield return "world!";
        }
    }

}
