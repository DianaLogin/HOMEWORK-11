using System;
using System.Collections.Generic;

namespace HOMEWORK_11
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

        private List<BankTransaction> all_transactions = new List<BankTransaction>();
        public List<BankTransaction> AllTransactions
        {
            get { return all_transactions; }
        }

        /// <summary>
        /// Индексатор в классе Банковский счёт для получения доступа клюбому объекту BankTransaction.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 && index <= all_transactions.Count)
                    return all_transactions[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public Bank_Shet (uint number, TypeBankShet type, string holder, decimal balance, List<BankTransaction> all_transactions)
        {
            this.number = number;
            this.type = type;
            this.holder = holder;
            this.balance = balance;
            this.all_transactions = all_transactions;
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
        /// Метод для печати данных Счёта в консоль
        /// </summary>
        public void PrintShet()
        {
            Console.WriteLine($"Номер аккаунта: {Number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип банковского счёта: {Type}\n");
            Console.WriteLine($"Держатель счёта: {Holder}");
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

        /// <summary>
        /// Метод для внесения денег Ha счёт
        /// </summary>
        /// <param name="money"></param>
        public void PlusMoney(decimal money)
        {
            if (money > 0)
            {
                balance += money;
                Console.WriteLine($"На ваш счёт успешно начислено {money} рублей, остаток {balance} рублей");
                all_transactions.Add(new BankTransaction(+money));
            }
            else
            {
                Console.WriteLine("Введите положительную сумму денег");
            }

        }

        /// <summary>
        /// Метод для снятия денег со счёта
        /// </summary>
        /// <param name="money"></param>
        public void MinusMoney(decimal money)
        {
            if (money <= balance)
            {
                balance -= money;
                Console.WriteLine($"С вашего счёта успешно снято {money} рублей, остаток {balance} рублей");
                all_transactions.Add(new BankTransaction(-money));
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия данной суммы\n");
            }
        }
    }
}
