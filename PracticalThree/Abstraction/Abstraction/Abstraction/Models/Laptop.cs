namespace Abstraction.Models;

internal class Laptop
{
    private string _brand = string.Empty;
    private string _model = string.Empty;

    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    /// <summary>
    /// this LaptopDetails Method will print Brand and Model 
    /// </summary>
    public void LaptopDetails()
    {
        Console.WriteLine("Brand: " + _brand);
        Console.WriteLine("Model: " + _model);
    }

    /// <summary>
    /// this methos can't be accessed outside class as it is private
    /// </summary>
    private void MotherBoardInfo()
    {
        Console.WriteLine("MotherBoard Information");
    }
}
