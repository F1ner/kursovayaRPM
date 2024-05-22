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
        string Name1 { get; set;}

        string Name2 { get; set; }
        public string OperatorName { get; set; }
        public int PhoneNumber { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Transaction() { }

        public Transaction(string name1, string name2, string operatorName, int phoneNumber, decimal amount, string currency)
        {
            Name1 = name1;
            Name2 = name2;
            OperatorName = operatorName;
            PhoneNumber = phoneNumber;
            Amount = amount;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"Ваше имя:{Name1}, Ваша фамилия:{Name2}, Имя оператора: {OperatorName}, Номер телефона: {PhoneNumber}, Сумма: {Amount} {Currency}";
        }
    }
}
