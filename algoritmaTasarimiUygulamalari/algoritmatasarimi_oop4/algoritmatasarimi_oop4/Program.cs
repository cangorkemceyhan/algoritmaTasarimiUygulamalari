using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmatasarimi_oop4
{
    public interface IEnumerator
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Merhaba";
            foreach(char c in s)
            {
                Console.Write(c+ ".");
            }

            Console.ReadKey();
        }
    }
}
