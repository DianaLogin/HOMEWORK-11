
namespace Тумаков_14
{
    [InfoAttribute(developers_Name: "Ленар Сафин", developers_Organization: "КФУ")]
    internal class Building
    {
        private static int unicNumber = 0;//Статистическое поле для хранения последнего использованного номера здания

        private readonly int number;
        public int Number
        {
            get { return number; }
        }

        private readonly double height;
        public double Height
        {
            get { return height; }
        }

        private readonly int floors;
        public int Floors
        {
            get { return floors; }
        }

        private readonly int apartments;
        public int Apartments
        {
            get { return apartments; }
        }

        private readonly int enters;
        public int Enters
        {
            get { return enters; }
        }

        /// <summary>
        /// Метод, увеличивающий значение статистического поля
        /// </summary>
        public Building(double height, int floors, int apartments, int enters)//Ну а по факту это конструктор класса 
        {
            unicNumber++;
            this.number = unicNumber;
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.enters = enters;

        }

        /// <summary>
        /// Метод для вычисления высоты этажа
        /// </summary>
        /// <returns></returns>
        public double CalculateFloorHeight()
        {
            return height / floors;
        }

        /// <summary>
        /// Метод для вычисления количества квартир в подъезде
        /// </summary>
        /// <returns></returns>
        public int CalculateApartmentsInEnter()
        {
            return apartments / enters;
        }

        /// <summary>
        /// Метод для вычисления количества квартир на этаже
        /// </summary>
        /// <returns></returns>
        public int CalculateApartmentsInFloor()
        {
            return apartments / floors;
        }
    }
}
