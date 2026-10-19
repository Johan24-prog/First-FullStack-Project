var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktivera Swagger i utvecklingsmiljö
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Tillfällig test-endpoint.

List<Products> products = [
    new (
        1, 
        "Celcius", 
        20.90m),
];

app.MapGet("/hello", () => "Hej från mitt API!");

app.MapPost("/Test", (int id, string product, decimal price) =>
{
    id = 1;
    product = "Celcius";
    price = 20.90m;
    
    return $"En {product} kostar {price}kr";
});

app.Run();