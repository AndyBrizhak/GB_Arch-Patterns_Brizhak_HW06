namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    /// <summary>
    /// Интерфейс, описывающий звено в цепочке полномочий работников
    /// </summary>
    public interface IElement
   {
        
        Employee Employee { get; set; }

        void LinkElement(IElement next);

       bool Сonsent(decimal request);
   }
}
