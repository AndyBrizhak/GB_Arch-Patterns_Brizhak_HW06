using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    public class Employee : IEmployee, IPosition
    {
        public string Name { get; set; }
        public string Position { get; set ; }
        public decimal Limit { get; set; }

        public Employee(string name, string position, decimal limit)
        {
            Name = name;
            Position = position ;
            Limit = limit;
        }
    }
}
