namespace Library_Management;
class Program
{
    public static void Main()
    {
        var address = new Address("Wall street", "NewYork", "Ohio", "234");
        var student = new StudentMember(222, "AAA", "1234567890", address);

        var book = new Book("Habit", "Mary Roschald", "Novel");
        var otherBook = new Book("Process", "Mary sandle", "sci-fi");

        var library = new Library();

        library.RegisterMember(student);
        library.AddBook(book);

        library.Show(222);
        Console.WriteLine("-------------------");
        library.Show("Habit");

        Console.WriteLine("-------------------");

        var bookManager = new BookManager(student);
        bookManager.IssueBook(book);
        library.Show(222);

        Console.WriteLine("-------------------");

        bookManager.ReturnBook();
        library.Show(222);

        Console.WriteLine("-------------------");
        library.Show(202);
        library.Show("Process");



    }
}
