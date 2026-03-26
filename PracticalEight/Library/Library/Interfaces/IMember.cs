namespace Library_Management.Interfaces;

internal interface IMember
{
    string Name { get; }
    int BooksIssued { get; }
    int MaxBooksAllowed { get; }
    MemberType Type { get; }

    bool CanIssueBooks();
    void IncrementBooks();
    void DecrementBooks();
}
