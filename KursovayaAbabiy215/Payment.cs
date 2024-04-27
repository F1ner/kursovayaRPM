using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaAbabiy215
{
    internal class Payment
    {
        public Operator Operator { get; set; }
        public string PhoneNumber { get; set; }
        public double Amount { get; set; }

        public Payment(Operator @operator, string phoneNumber, double amount)
        {
            Operator = @operator;
            PhoneNumber = phoneNumber;
            Amount = amount;
        }
    }
}
