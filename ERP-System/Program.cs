var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<Products> products = [
    new Products (1, "Celcius", 20.90m),
    new Products (2, "Nocco", 20.90m),
    new Products (3, "Coca-Cola", 15.90m),
    new Products (4, "Sprite", 15.90m),
    new Products (5, "Fanta", 15.90m)
];

app.MapGet("/products", () => products);

app.MapGet("/products/{id}", (int id) =>
{
    var product = products.FirstOrDefault(p => p.Id == id);
    if (product is null)
    {
        return Results.NotFound();
    }

    return Results.Ok();
});

app.MapPost("/products", (Products product) =>
{
    products.Add(product);

    return Results.Created($"/products/{product.Id}", product);
});

app.Run();