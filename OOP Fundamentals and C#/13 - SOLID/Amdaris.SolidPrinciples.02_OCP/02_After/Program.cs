Payment creditCardPayment = new Payment(PaymentType.CreditCard);
Payment paypalPayment = new Payment(PaymentType.PayPal);

PaymentProcessor paymentProcessor = new PaymentProcessor();

paymentProcessor.AddPaymentProcessor(PaymentType.CreditCard, new CreditCardPaymentProcessor());
paymentProcessor.AddPaymentProcessor(PaymentType.PayPal, new PayPalPaymentProcessor());

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

public interface IPaymentProcessor
{
    void ProcessPayment(Payment payment);
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Payment payment)
    {
        Console.WriteLine("Processing credit card payment ...");
    }
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(Payment payment)
    {
        Console.WriteLine("Processing paypal payment ...");
    }
}

public class PaymentProcessor
{
    private readonly Dictionary<PaymentType, IPaymentProcessor> paymentProcessors;

    public PaymentProcessor()
    {
        paymentProcessors = new Dictionary<PaymentType, IPaymentProcessor>();
    }

    public void AddPaymentProcessor(PaymentType paymentType, IPaymentProcessor paymentProcessor)
    {
        paymentProcessors.Add(paymentType, paymentProcessor);
    }

    public void ProcessPayment(Payment payment)
    {
        if (paymentProcessors.ContainsKey(payment.Type))
        {
            IPaymentProcessor paymentProcessor = paymentProcessors[payment.Type];
            paymentProcessor.ProcessPayment(payment);
        }
        else
        {
            throw new InvalidOperationException("Invalid payment type.");
        }
    }
}
#endregion
