// [WebApplication.CreateBuilder] - Skapar och konfigurerar en builder för Webbapplikationen.
// [args] - Innehåller argument som skickas till programmet när det startas.

// Steg 1. Skapa Buildern för Webbapplikationen.
var builder = WebApplication.CreateBuilder(args);

// Registrera tjänster för Swagger.
// [Builder] - Används för att konfigurera applikationen innan den körs.
// [Services] - Inte ett bibliotek! Samling med funktioner som applikationen behöver.
// [AddEndpointsApiExplorer] - Registrerar funktionalitet som hjälper till att beskriva API-endpoints.

// [AddSwaggerGen()] - Registrerar tjänster för att generera Swagger-dokumentation.
// [UseSwagger()] - Gör Swagger-dokumentet tillgängligt via HTTP.
// [UseSwaggerUI] - Aktiverar det grafiska gränssnittet där du kan testa API:et.

// Builder = Förbereder applikationen.
// Build() = Skapar applikationen utifrån förberedelserna.
// App = Objekt som används för konfiguration och start.

// Steg 2. Lägg till tjänster som behövs (I detta fall Swagger)
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();

// Steg 3. Skapa objektet med tjänsterna.
var app = builder.Build();

// Aktivera Swagger i utvecklingsmiljö
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Steg 4. Konfigurera HTTP-hanteringen
// Försöker göra om HTTP till HTTPS.
app.UseHttpsRedirection();

// Tillfällig test-endpoint.
app.MapGet("/", () => "Hej från mitt API!");

// Steg 5. Starta appen
// Startar hela applikationen med tjänster, förberedelser och HTTP-hanteringen.
app.Run();