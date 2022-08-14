using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class SqlServer:DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted in SQLServer");
        }
    }
}
