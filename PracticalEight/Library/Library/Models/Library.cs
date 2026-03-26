namespace Library_Management.Models;

internal class Library
{
    readonly List<Book> ListOfBooks = new List<Book>();
    readonly List<Member> ListOfMember = new List<Member>();

    /// <summary>
    /// Takes Book Object and adds it to ListOfBooks
    /// </summary>
    /// <param name="book"></param>
    public void AddBook(Book book)
    {
        try {
            if(book == null)
            {
                throw new ArgumentNullException();
            }
            ListOfBooks.Add(book);
            Console.WriteLine($"\nBook::{book.Title.ToCapitalize()} Added Successfully");
        }
        catch(ArgumentNullException ex)
        { 
            Console.WriteLine("Book :: " + ex.Message);
        }
        
    }

    /// <summary>
    /// Takes Member Object and adds it to ListOfBooks
    /// </summary>
    /// <param name="member"></param>
    public void RegisterMember(Member member)
    {
        try
        {
            if (member == null)
            {
                throw new ArgumentNullException();
            }
            ListOfMember.Add(member);
            Console.WriteLine($"\nMember::{member.Type.ToString()} Added Successfully");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Member :: " + ex.Message);
        }
    }

    /// <summary>
    /// Takes Member Id and shows Member Information
    /// </summary>
    /// <param name="Id"></param>
    public void Show(int id)
    {
        Member? member = ListOfMember.Find(member => member.MemberId == id);

        if (member != null)
        {
            member.GetDetails();
        }
        else
        {
            Console.WriteLine("Member not found.");
        }
    }

    /// <summary>
    /// Takes Book title and shows Book Information
    /// </summary>
    /// <param name="title"></param>
    public void Show(string title)
    {
        Book? book = ListOfBooks.Find(book => book.Title == title.ToLower());

        if (book != null)
        {
            book.GetDetails();
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}
