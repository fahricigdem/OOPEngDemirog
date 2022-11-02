using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }
    }
}
