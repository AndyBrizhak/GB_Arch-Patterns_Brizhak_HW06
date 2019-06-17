using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    class Element : IElement
    {
        private IElement _next;

        public Element()
        {
        }

        Employee IElement.Employee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IElement.LinkElement(IElement next)
        {
            this._next = next;
        }
    }
}
