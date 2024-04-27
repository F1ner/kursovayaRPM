using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaAbabiy215
{
    class PaymentSystem
    {
        private Operator selectedOperator;
        private string phoneNumber;
        private double paymentAmount;

        public void SelectOperator()
        {
            Console.Write("Введите название оператора: ");
            string name = Console.ReadLine();
            selectedOperator = new Operator(name);
        }

        public void EnterPhoneNumber()
        {
            Console.Write("Введите номер телефона: ");
            phoneNumber = Console.ReadLine();
        }

        public void ReceiveCash()
        {
            Console.Write("Введите сумму наличных: ");
            paymentAmount = double.Parse(Console.ReadLine());
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Чек:");
            Console.WriteLine($"Оператор: {selectedOperator.Name}");
            Console.WriteLine($"Номер телефона: {phoneNumber}");
            Console.WriteLine($"Сумма платежа: {paymentAmount}");
        }
    }
}
