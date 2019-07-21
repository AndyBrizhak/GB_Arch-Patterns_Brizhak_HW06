namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    /// <summary>
    /// Интерфейс описывающий должность и полномочия работника
    /// </summary>
    public  interface IPosition
    {
        string Position { get; set; }
        decimal Limit { get; set; }
    }
}
