namespace RealDependencies.PaymentProcessing;

public interface IProcessesPayments
{
    string HandlePayment(decimal paymentAmount);
}