using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ДЗ к уроку 6 по курсу Архитектуры и шаблоны проектирования Брижак Андрей
//1. Используя шаблон «Цепочка обязанностей», реализовать следующую задачу: сотрудник
//компании желает получить одобрение на получение некоторой суммы денег.Для получения
//одобрения сотрудник обращается к непосредственному руководителю.Руководитель не
//имеет полномочий одобрить выделение такой суммы денег (может одобрить меньшую сумму)
//и обращается к своему руководителю(директору компании). Директор компании может
//одобрить или отклонить запрос и отправить ответ сотруднику.

namespace GB_Arch_Patterns_Brizhak_HW06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee  Vasia=new Employee();
            Element firstElement=new Element(new Employee("Vasia","Manager", 0));

        }
    }
}
