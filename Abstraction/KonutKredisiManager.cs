using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class KonutKredisiManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("KonutKredisi Hesapla");
        }
    }
}
