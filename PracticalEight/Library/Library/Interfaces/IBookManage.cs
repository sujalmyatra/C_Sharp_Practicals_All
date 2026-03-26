namespace Library_Management.Interfaces;

internal interface IBookManage
{
    void IssueBook(Book book);
    void ReturnBook();
}
