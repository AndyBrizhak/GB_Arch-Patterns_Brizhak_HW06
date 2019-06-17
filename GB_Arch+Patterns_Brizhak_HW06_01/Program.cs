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
            
            var firstElement=new Element(new Employee("Vasia","Manager", 0));
            var secondElement = new Element(new Employee("Ivan", "Boss", 10));
            var thirdElement=new Element(new Employee("Maria", "SuperBoss", 100));

            firstElement.LinkElement(secondElement);
            secondElement.LinkElement(thirdElement);

            decimal r0 = 0;
            decimal r10 = 10;
            decimal r88 = 88;
            decimal r101 = 101;

            Console.WriteLine($"Запрос {r0} ");
            firstElement.Сonsent(r0);
            Console.ReadKey();

            Console.WriteLine($"Запрос {r10} ");
            firstElement.Сonsent(r10);
            Console.ReadKey();

            Console.WriteLine($"Запрос {r88} ");
            firstElement.Сonsent(r88);
            Console.ReadKey();

            Console.WriteLine($"Запрос {r101} ");
            firstElement.Сonsent(r101);
            Console.ReadKey();



        }
    }
}
