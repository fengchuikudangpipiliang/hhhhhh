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
            
        }
    }
    class Test : IComparable
    {
        public int value;
        public int CompareTo(object obj)
        {
            Test testOther = obj as Test;
            if(this.value<testOther.value)
            {
                return -1;
            }
            else if(this.value>testOther.value){
                return 1;
            }   
            return 0;

        }
    }

}
    