// En tom produktblankett som vill ha fälten här ifyllda.
public class Products
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }

    public Products(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}