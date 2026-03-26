namespace Single_Responsibility_Principle.Models;

internal class ArticleDataBaseManager
{
    readonly Article article;
    public ArticleDataBaseManager(Article article)
    {
        this.article = article;
    }

    /// <summary>
    /// this method will save article to database
    /// </summary>
    public void SaveArticle()
    {
        //Logic to Save Article
        Console.WriteLine($"Article Saved :: Title :: {article.Title}");
    }

    /// <summary>
    /// this method will retrieve article from database
    /// </summary>
    public Article GetArticle()
    {
        Console.WriteLine($"Getting Article::{article.Title}");
        //Logic to Retrieve Article
        return new Article();
    }
}
