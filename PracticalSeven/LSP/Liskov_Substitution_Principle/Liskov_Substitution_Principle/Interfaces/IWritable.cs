namespace Liskov_Substitution_Principle.Interfaces;

internal interface IWritable
{
    string Content { get; set; }
    void Write(string content);
}
