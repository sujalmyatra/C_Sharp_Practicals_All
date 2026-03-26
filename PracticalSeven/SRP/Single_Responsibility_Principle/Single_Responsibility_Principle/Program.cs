using Single_Responsibility_Principle.Models;

namespace Single_Responsibility_Principle;
class Program
{
    public static void Main()
    {
        var article = new Article()
        {
            Title = "Habits",
            Content = "A habit is a behavior that we do regularly without thinking much. Good habits help us grow and succeed."
        };

        var articleDBManager = new ArticleDataBaseManager(article);
        articleDBManager.SaveArticle();

        ArticleSummrizer articleSummary = new ArticleSummrizer(article);
        Console.WriteLine(articleSummary.GenerateSummary());

    }
}