public class Products
{
    // Properties - Som tillhör klassen.
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }

    // Konstruktor - parametrar som konstruktorn tar emot.
    public Products(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}