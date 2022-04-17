using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Countdown : IEnumerator
    {
        private int _count = 11;
        public bool MoveNext() => _count-- > 0;
        public void Reset() => _count = 0;
        public object Current => _count;
    }
}
