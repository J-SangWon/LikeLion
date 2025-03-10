using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion24
{
    //인터페이스를 사용하면 기존 코드 변경없이 새로은 기능 추가 간으
    interface IPayment
    {
        void ProcessPayment();
    }
    class CreditCard : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("신용카드 결제");
        }
    }
    class PayPalPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("PayPal 결제");
        }
    }

    class PaymentProcessor
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();
            IPayment creditCard = new CreditCard();
            IPayment paypal = new PayPalPayment();

            processor.Pay(creditCard);
            processor.Pay(paypal);
        }
    }
}
