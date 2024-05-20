var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseHttpsRedirection(); //redirects to https 

// Routing


//read "/shirts"
app.MapGet("/shirts", () =>
{
    return "Reading all the shirts";
});

app.MapGet("/shirt/{id}", (int id) =>
{
    return $"Reading shirt with ID: {id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating a shirt.";
});

app.MapPut("/shirt/{id}", (int id) =>
{
    return $"Updating shirt with ID: {id}";
});

app.MapDelete("/shirt/{id}", (int id) =>
{
    return $"Deleting shirt with ID: {id}";
});

app.Run();
