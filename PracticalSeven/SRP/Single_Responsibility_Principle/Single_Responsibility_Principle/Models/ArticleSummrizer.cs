namespace Single_Responsibility_Principle.Models;

internal class ArticleSummrizer
{
    readonly Article article;

    public ArticleSummrizer(Article article)
    {
        this.article = article;
    }

    /// <summary>
    /// this method will generate summary of article content
    /// </summary>
    public string GenerateSummary()
    {
        string summary = article.Content ?? "";
        return String.Concat("\nSummary :: ", summary.Substring(0, 50), "...");
    }
}
