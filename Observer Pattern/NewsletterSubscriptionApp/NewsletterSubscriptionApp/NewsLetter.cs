namespace NewsletterSubscriptionApp;

public class NewsLetter
{
    public string Title { get; set; }
    public string Content { get; set; }

    public NewsLetter(string title, string content)
    {
        this.Title = title;
        this.Content = content;
    }
}
