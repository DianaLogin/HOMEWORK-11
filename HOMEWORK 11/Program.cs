using System;
namespace HOMEWORK_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================== Домашнее заданаие 13.1 =======================================

            Building building_1 = new Building(17.00, 6, 67, 1);
            Console.WriteLine($" Высота: {building_1.Height},\n Этажей: {building_1.Floors},\n Квартир: {building_1.Apartments},\n Подъездов: {building_1.Enters}");

            //==================================== Домашнее заданаие 13.2 =======================================

            Buildingsss myBuildings = new Buildingsss();
            myBuildings[0] = 67;//так можно присвоить значение для зданий определенного индекса
            Console.WriteLine(myBuildings[0]);
        }
    }
}
    
