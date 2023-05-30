Payment creditCardPayment = new Payment(PaymentType.CreditCard);
Payment paypalPayment = new Payment(PaymentType.PayPal);

PaymentProcessor paymentProcessor = new PaymentProcessor();

paymentProcessor.ProcessPayment(creditCardPayment);
paymentProcessor.ProcessPayment(paypalPayment);

#region Classes
public enum PaymentType
{
    CreditCard,
    PayPal
}

public class Payment
{
    public Payment(PaymentType type)
    {
        Type = type;
    }

    public PaymentType Type { get; set; }
    public decimal Amount { get; set; }
}

public class PaymentProcessor
{
    public void ProcessPayment(Payment payment)
    {
        if (payment.Type == PaymentType.CreditCard)
        {
            Console.WriteLine("Processing credit card payment ...");
        }
        else if (payment.Type == PaymentType.PayPal)
        {
            Console.WriteLine("Processing paypal payment ...");
        }
        else
        {
            throw new InvalidOperationException("Invalid payment type.");
        }
    }
}
#endregion
