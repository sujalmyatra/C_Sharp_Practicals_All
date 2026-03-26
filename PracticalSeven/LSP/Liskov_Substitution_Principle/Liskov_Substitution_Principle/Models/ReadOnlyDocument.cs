namespace Liskov_Substitution_Principle.Models;

internal class ReadOnlyDocument : IReadable
{
    public string Content { get; }

    public ReadOnlyDocument(string content)
    {
        Content = content;
    }

    /// <summary>
    /// this method will provide read capability
    /// </summary>
    public void Read()
    {
        Console.WriteLine("\n---Inside ReadOnly Read---\n");
        Console.WriteLine($"Reading::{Content}\n");
    }
}
