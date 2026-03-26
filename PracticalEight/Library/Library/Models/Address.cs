namespace Library_Management.Models;

internal class Address(string street, string city, string state, string pincode)
{
    public string? Street { get; set; } = street;
    public string? City { get; set; } = city;
    public string? State { get; set; } = state;
    public string? Pincode { get; set; } = pincode;

    /// <summary>
    /// This Prints Combined Address on Console
    /// </summary>
    /// <returns></returns>
    public string GetAddress()
    {
        return $"{Street}, {City}, {State} - {Pincode}";
    }
}
