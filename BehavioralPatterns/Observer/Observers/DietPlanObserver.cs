namespace BehavioralPatterns.Observer.Observers;

public class DietPlanObserver : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine($"{nameof(DietPlanObserver)}: Reacted to the event.");
    }
}