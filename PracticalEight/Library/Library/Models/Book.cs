namespace Library_Management.Models;

internal class Book(string title, string author, string genre)
{
    public string Title { get; set; } = title.ToLower().Trim();
    public string? Author { get; set; } = author.Trim();
    public string? Genre { get; set; } = genre.Trim();

    /// <summary>
    /// This Prints Combined Book Information on Console
    /// </summary>
    public void GetDetails()
    {
        Console.WriteLine("\n--Book Details--\n");
        Console.WriteLine($"Title :: {Title.ToCapitalize()}");
        Console.WriteLine($"Author :: {Author}");
        Console.WriteLine($"Genre :: {Genre}");
    }

}
