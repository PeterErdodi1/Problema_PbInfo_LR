using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_LR
{
    abstract class LR
    {
        public void Init()
        {
            GetN();
            Calculate();
            Write();

        }
        abstract protected void GetN();
        abstract protected void Calculate();
        abstract protected void Write();

    }
}
