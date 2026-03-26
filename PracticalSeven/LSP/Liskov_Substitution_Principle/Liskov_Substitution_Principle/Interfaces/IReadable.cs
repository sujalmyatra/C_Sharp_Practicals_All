namespace Liskov_Substitution_Principle.Interfaces;

internal interface IReadable
{
    string Content { get; }
    void Read();
}
