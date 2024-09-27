namespace BehavioralPatterns.Observer.Observers;

public class ProfileObserver : IObserver
{
    public void Update(ISubject subject)
    {
        Console.WriteLine($"{nameof(ProfileObserver)}: Reacted to the event.");
    }
}