namespace NewsletterSubscriptionApp;

public class NewsLetterManagement
{
    public Dictionary<SubscriptionType, List<Subscriber>> subscribers;
    public List<NewsLetter> newsLetters;
    public List<BlogPost> blogPosts;


    public NewsLetterManagement()
    {
        subscribers = new Dictionary<SubscriptionType, List<Subscriber>>();
        newsLetters = new List<NewsLetter>();
        blogPosts = new List<BlogPost>();
        initSubscriptions();
    }


    public void Subscribe(SubscriptionType type, Subscriber subscriber)
    {
        if (!subscribers[type].Contains(subscriber))
            subscribers[type].Add(subscriber);
    }

    public void Unsubscribe(SubscriptionType type, Subscriber subscriber)
    {
        subscribers[type].Remove(subscriber);
    }

    public void WriteNewBlogPost(BlogPost blogPost)
    {
        blogPosts.Add(blogPost);
        NotifyReaders(SubscriptionType.BLOG_POST, $"{blogPost.Title} was published");
    }

    public void WriteNewNewsLetter(NewsLetter newsLetter)
    {
        newsLetters.Add(newsLetter);
        NotifyReaders(SubscriptionType.NEWSLETTER, $"{newsLetter.Title} was published");
    }

    private void NotifyReaders(SubscriptionType type, string message)
    {     
        foreach (var subscriber in subscribers[type])
            subscriber.Notify(message);
    }

    private void initSubscriptions()
    {
        subscribers.Add(SubscriptionType.NEWSLETTER, new List<Subscriber>());
        subscribers.Add(SubscriptionType.BLOG_POST, new List<Subscriber>());
    }
}
