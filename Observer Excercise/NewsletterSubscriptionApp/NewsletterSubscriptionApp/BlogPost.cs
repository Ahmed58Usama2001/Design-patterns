namespace NewsletterSubscriptionApp;

public class BlogPost
{
    public string Title { get; set; }
    public string Content { get; set; }

    public BlogPost(string title, string content)
    {
        this.Title = title;
        this.Content = content;
    }
}
