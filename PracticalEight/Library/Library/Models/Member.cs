namespace Library_Management.Models;

abstract class Member(int id, string name, string phoneNumber,Address address) : IMember
{
    public int MemberId { get; set; } = id;
    public string Name { get; set; } = name.Trim();
    public string? PhoneNumber { get; set; } = phoneNumber.Trim();
    public Address MemberAddress { get; set; } = address;
    public MemberType Type { get; protected set; }  
    public int MaxBooksAllowed { get; protected set; }
    public int BooksIssued { get; protected set; }

    /// <summary>
    /// Checks for Member can issue book or not
    /// </summary>
    /// <returns></returns>
    public bool CanIssueBooks()
    {
        return BooksIssued < MaxBooksAllowed;
    }

    /// <summary>
    /// Increments issued book count of Member
    /// </summary>
    public void IncrementBooks()
    {
        BooksIssued++;
    }

    /// <summary>
    /// Decrements issued book count of Member
    /// </summary>
    public void DecrementBooks()
    {
        if (BooksIssued > 0)
            BooksIssued--;
        else
        {
            Console.WriteLine("There are no books allocated.");
        }
    }

    /// <summary>
    /// Prints Member information on Console
    /// </summary>

    public virtual void GetDetails()
    {
        Console.WriteLine("\n--Member Details--\n");

        Console.WriteLine($"MemberId :: {MemberId}");
        Console.WriteLine($"Name :: {Name}");
        Console.WriteLine($"PhoneNumber :: {PhoneNumber}");
        Console.WriteLine($"Type :: {Type.ToString()}");
        Console.WriteLine($"Address :: {MemberAddress.GetAddress()}");
        Console.WriteLine($"BooksIssued :: {BooksIssued}");
    }

}
