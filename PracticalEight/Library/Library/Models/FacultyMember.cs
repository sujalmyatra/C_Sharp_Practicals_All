namespace Library_Management.Models;

internal class FacultyMember : Member
{
    public FacultyMember(int id, string name, string phoneNumber, Address address) : base(id, name, phoneNumber, address)
    {
        MaxBooksAllowed = 5;
        Type = MemberType.Faculty;
    }
    /// <summary>
    /// Calls parent GetDetails() and prints Max book allowed for faculty 
    /// </summary>
    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine($"MaxBooksAllowed :: {MaxBooksAllowed}");
    }
}
