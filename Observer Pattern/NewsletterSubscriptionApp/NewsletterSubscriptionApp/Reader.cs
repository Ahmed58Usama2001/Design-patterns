namespace NewsletterSubscriptionApp;

public class Reader : Subscriber
{
    public string Name { get; set; }

    public void Notify(string message)
    {
        Console.WriteLine($"Notify user {Name} that: {message}");
    }
}
