namespace Library_Management.Models;

internal class StudentMember : Member
{
    public StudentMember(int id,string name,string phoneNumber,Address address) : base(id, name, phoneNumber, address)
    {
        MaxBooksAllowed = 3;
        Type = MemberType.Student;
    }
    /// <summary>
    /// Calls parent GetDetails() and prints Max book allowed for student 
    /// </summary>
    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine($"MaxBooksAllowed :: {MaxBooksAllowed}\n");
    }
}

