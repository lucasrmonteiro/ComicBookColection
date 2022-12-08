using ComicBookCollection.IoC;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureDI();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
