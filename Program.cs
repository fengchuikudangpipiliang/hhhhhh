using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using _2024_11_25_c_;
using Super;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace hhhhhh
{
    delegate void  MyDel();
    internal class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.PrintOut();

            ITest i1=derivedClass as ITest;
            ITest2 i2=derivedClass as ITest2;
            i1.PrintOut();
            i2.PrintOut();
        }
    }
    interface ITest
    {
        void PrintOut();
    }
    interface ITest2 {
        void PrintOut();
    }

    class MyBaseClass
    {
        public void PrintOut() => Console.WriteLine("Base实现");
    }
    class DerivedClass : MyBaseClass, ITest,ITest2
    {
        void ITest.PrintOut() => Console.WriteLine("显示实现ITest"); 
        void ITest2.PrintOut()=>Console.WriteLine("显示实现ITest2");
    }

}
    