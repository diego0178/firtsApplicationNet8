var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "my first aplicattions in staging!");

app.Run();
