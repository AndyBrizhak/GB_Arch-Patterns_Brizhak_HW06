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
        private Employee _employee;

        public Element(Employee employee)
        {
            _employee = employee;
        }

        Employee IElement.Employee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void LinkElement(IElement next)
        {
            this._next = next;
        }
    }
}
