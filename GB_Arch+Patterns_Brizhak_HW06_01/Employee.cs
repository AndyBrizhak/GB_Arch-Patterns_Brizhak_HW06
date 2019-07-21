namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    /// <summary>
    /// Класс Работник
    /// </summary>
    public class Employee : IEmployee, IPosition
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Должность работника
        /// </summary>
        public string Position { get; set ; }
        /// <summary>
        /// Лимит суммы денежных средств на одобрение
        /// </summary>
        public decimal Limit { get; set; }

        public Employee(string name, string position, decimal limit)
        {
            Name = name;
            Position = position ;
            Limit = limit;
        }
    }
}
