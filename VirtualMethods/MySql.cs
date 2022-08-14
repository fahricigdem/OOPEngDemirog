using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class MySql:DataBase
    {
        public override void Add()
        {
            //base.Add();
            Console.WriteLine("Do it for MySql...");
        }
    }
}
