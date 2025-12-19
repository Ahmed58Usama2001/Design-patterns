using System;

namespace NewsletterSubscriptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create manager (Subject)
            var manager = new NewsLetterManagement();

            // Create readers (Observers)
            var ahmed = new Reader { Name = "Ahmed" };
            var sara = new Reader { Name = "Sara" };
            var omar = new Reader { Name = "Omar" };

            // Subscriptions
            manager.Subscribe(SubscriptionType.NEWSLETTER, ahmed);
            manager.Subscribe(SubscriptionType.NEWSLETTER, sara);

            manager.Subscribe(SubscriptionType.BLOG_POST, sara);
            manager.Subscribe(SubscriptionType.BLOG_POST, omar);

            // Publish newsletter (all newsletter subscribers get it)
            manager.WriteNewNewsLetter(
                new NewsLetter("Weekly Tech News", "Latest updates in tech")
            );

            manager.WriteNewBlogPost(
                new BlogPost("strategy Pattern in C#", "A deep dive into strategy Pattern")
            );

            Console.WriteLine("---- Unsubscribing Sara from BLOG_POST ----");

            // Unsubscribe test
            manager.Unsubscribe(SubscriptionType.BLOG_POST, sara);

            // Publish blog post (Sara should NOT get this)
            manager.WriteNewBlogPost(
                new BlogPost("Observer Pattern in C#", "A deep dive into Observer Pattern")
            );

            Console.ReadLine();
        }
    }
}
