using System;

namespace HOMEWORK_11
{
    internal class BankTransaction
    {
        private decimal sum;
        public decimal Sum
        {
            get { return sum; }
        }

        private readonly DateTime transaction_Date;
        public DateTime Transaction_Date
        {
            get { return transaction_Date; }
        }

        public BankTransaction(decimal sum, DateTime transaction_Date)
        {
            this.sum = sum;
            this.transaction_Date = DateTime.Now;
        }

        public BankTransaction(decimal sum)
        { 
            this.sum = sum;
        }
    }
}
