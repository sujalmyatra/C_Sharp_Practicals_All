namespace Library_Management.Models;

sealed class BookManager(Member member) : IBookManage
{
    private readonly IMember _member = member;

    /// <summary>
    /// This ensures member can Issue book or not and updates issued book count
    /// </summary>
    /// <param name="book"></param>
    public void IssueBook(Book book)
    {
        if (!_member.CanIssueBooks())
        {
            Console.WriteLine($"{_member.Type.ToString()} cannot issue more than {_member.MaxBooksAllowed} books.");
            return;
        }
        _member.IncrementBooks();
        Console.WriteLine($"{book.Title} issued to {_member.Name}. Total books: {_member.BooksIssued}");
    }

    /// <summary>
    /// This ensures member have issued books or not and updates issued book count 
    /// </summary>
    public void ReturnBook()
    {
        if (_member.BooksIssued > 0)
        {
            _member.DecrementBooks();
            Console.WriteLine($"Remaining books: {_member.BooksIssued} of {_member.Name}.");
        }
        else
        {
            Console.WriteLine("No books to be returned.");
        }
    }
}
