using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace icr.List_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 0;
            byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = " ";
            Exception ex = new Exception();
            object[] types = { a, b, c, d, e, s, ex };

            foreach (object obj in types)
            {
                string type;
                if (obj.GetType().IsValueType)
                    type = "Value type";
                else
                    type = "Reference Type";
                Console.WriteLine($"{obj.GetType()}: {type}");
            }
            Console.ReadKey();
        }
    }
}
