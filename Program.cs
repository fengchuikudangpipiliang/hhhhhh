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
using System.Collections;

namespace hhhhhh
{
    delegate void  MyDel();
    internal class Program
    {
        static void Main()
        {
            string[] colors = { "hel", "yaya", "yoyo" };
            Spectrum spectrum = new Spectrum();
            spectrum.colors = colors;
            foreach (string color in spectrum)
            {
                Console.WriteLine(color);   
            }
        }
    }
    class ColorEnumerator : IEnumerator
    {
        public string[] colors;
        public int index=-1;

        public ColorEnumerator(string[] colors) 
        {
            this.colors = colors;
            index = -1;
        }
        public object Current
        {
            get 
            {
                if (index < 0) throw new IndexOutOfRangeException();
                if(index >= colors.Length) throw new IndexOutOfRangeException();
                return colors[index];   
            }
        }

        public bool MoveNext()
        {
            index ++;
            if(index <colors.Length) return true;
            else return false;
        }

        public void Reset()
        {
            index = -1;
        }

    }
    class Spectrum : IEnumerable
    {
        public string[] colors;
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }
    }


}
