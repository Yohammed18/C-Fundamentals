var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Routing
// Middleware  component app.Use...
app.UseRouting();

app.MapControllers();   

app.Run();