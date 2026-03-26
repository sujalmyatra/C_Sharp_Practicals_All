namespace Liskov_Substitution_Principle;
class Program
{
    public static void Main()
    {
        var readOnlyDocument = new ReadOnlyDocument("Readonly Document");
        readOnlyDocument.Read();

        var writeDocument = new WritableDocument("Writable Document");
        writeDocument.Write("Added content");
        writeDocument.Read();

    }
}
