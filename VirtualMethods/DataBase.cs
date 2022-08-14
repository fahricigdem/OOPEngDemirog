using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
    }
}
