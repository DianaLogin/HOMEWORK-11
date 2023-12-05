using System;

namespace Тумаков_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================== Упражнение 14.1 =======================================

            Console.WriteLine("=============== Упражнение 14.1 ==============");
            Bank_Shet shet = new Bank_Shet(12345, TypeBankShet.Saving, "Diana", 100000000);
            shet.DumpToScreen();

            //==================================== Упражнение 14.2 =======================================

            Console.WriteLine("=============== Упражнение 14.2 ==============");
            foreach (Attribute a in typeof(Rational_nums).GetCustomAttributes(false))
            {
                if (a is DeveloperInfoAttribute)
                {
                    DeveloperInfoAttribute attribute = a as DeveloperInfoAttribute;
                    Console.WriteLine($"Разработчик: {attribute.Developers_Name}, Дата разработки: {attribute.Development_Date}");
                }
            }

            //==================================== Домашнее заданаие 14.1 =======================================

            Console.WriteLine("=============== Домашнее заданаие 14.1 ==============");
            foreach (Attribute b in typeof(Building).GetCustomAttributes(false))
            {
                if (b is InfoAttribute)
                {
                    InfoAttribute attribute = b as InfoAttribute;
                    Console.WriteLine($"Разработчик: {attribute.Developers_Name}, Организация: {attribute.Developers_Organization}");
                }
            }
        }   
    }
}
