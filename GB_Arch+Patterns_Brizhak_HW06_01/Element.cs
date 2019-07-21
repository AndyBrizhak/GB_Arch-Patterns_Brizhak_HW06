using System;

namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    /// <summary>
    /// Класс Элемент в цепочке обязанностей
    /// </summary>
    class Element : IElement
    {
        private IElement _next;
        private Employee _employee;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employee"></param>
        public Element(Employee employee)
        {
            this._employee = employee;
        }

        public Employee Employee { get; set ; }

        

        /// <summary>
        /// Метод установки следующего звена в цепочке
        /// </summary>
        /// <param name="next"></param>
        public void LinkElement(IElement next)
        {
            this._next = next;
        }

        /// <summary>
        /// Метод согласования, запрашиваемой суммы
        /// </summary>
        /// <param name="request">Сумма запроса</param>
        /// <returns></returns>
        public bool Сonsent(decimal request)
        {
            if (_employee != null && _employee.Limit >= request)
            {
                Console.WriteLine($"Запрос одобрен {_employee.Position}  {_employee.Name}");
                return true;
            }

            if (_next != null)
            {
                Console.WriteLine("Запрос передан на рассмотрение" );
                return _next.Сonsent(request);
            }

            Console.WriteLine($"Запрос отклонен {_employee.Position}  {_employee.Name}");
            return false;

        }
    }
}
