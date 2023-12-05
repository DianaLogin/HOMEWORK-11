using System;
using System.Diagnostics;

namespace Тумаков_14
{
    enum TypeBankShet
    {
        Saving,
        Current,
        Credit
    }
    internal class Bank_Shet
    {
        private static uint newNumber = 0;

        private readonly uint number;
        public uint Number
        {
            get { return number; }
        }

        private readonly TypeBankShet type;
        public TypeBankShet Type
        {
            get { return type; }
        }

        private string holder;
        public string Holder
        {
            get { return holder; }
            set { holder = value; }
        }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
        }

        public Bank_Shet(uint number, TypeBankShet type, string holder, decimal balance)
        {
            this.number = number;
            this.type = type;
            this.holder = holder;
            this.balance = balance;
        }

        //===========================  !!! МЕТОД ДЛЯ УПРАЖНЕНИЯ 14.1 !!! =============================

        /// <summary>
        /// Метод, который отображает детали банковского счёта 
        /// </summary>
        [ConditionalAttribute("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Номер аккаунта: {Number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип банковского счёта: {Type}\n");
            Console.WriteLine($"Держатель счёта: {Holder}");
        }

        /// <summary>
        /// Метод, который увеличивает значение статистической переменной
        /// </summary>
        /// <returns></returns>
        public static uint GenerateNumber()
        {
            uint number = newNumber++;
            return number;
        }

        /// <summary>
        /// Метод, который переводит деньги с одного счёта на другой
        /// </summary>
        /// <param name="shet"></param>
        /// <param name="money"></param>
        public void TransferMoney(ref Bank_Shet shet_1, decimal money)
        {
            if (balance <= money)
            {
                shet_1.balance -= money;
                balance += money;

            }
            else { Console.WriteLine("Недостаточно средств для перевода"); }
        }
    }
}
