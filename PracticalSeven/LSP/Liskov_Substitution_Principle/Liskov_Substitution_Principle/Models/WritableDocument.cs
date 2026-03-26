namespace Liskov_Substitution_Principle.Models;

internal class WritableDocument : IReadable, IWritable
{
    public string Content { get; set; }

    public WritableDocument(string content)
    {
        Content = content;
    }

    /// <summary>
    /// this method will provide read capability
    /// </summary>
    public void Read()
    {
        Console.WriteLine("\n---Inside Editable Read---\n");
        Console.WriteLine($"Reading::{Content}\n");
    }

    /// <summary>
    /// this method will provide write capability
    /// </summary>
    public void Write(string content)
    {
        Console.WriteLine("\n---Inside Editable Write---\n");
        Console.WriteLine("Writing");
        Content += String.Concat(" ", content);
    }
}
