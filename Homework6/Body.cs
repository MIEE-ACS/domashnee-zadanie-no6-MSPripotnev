using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    abstract class Body
    {
        public virtual decimal Area() => 0;
        public virtual decimal Volume() => 0;
    }
}
