using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ababiyrpmkurs215
{
    [Serializable]
    class Transaction
    {
        public string OperatorName { get; set; }
        public int PhoneNumber { get; set; }
        public decimal Amount { get; set; }
        public Transaction() { }
        public Transaction(string operatorName, int phoneNumber, decimal amount)
        {
            OperatorName = operatorName;
            PhoneNumber = phoneNumber;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Имя оператора: {OperatorName}, Номер телефона: {PhoneNumber}, Сумма наличных: {Amount}";
        }
    }
}
