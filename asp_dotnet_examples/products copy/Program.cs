using products.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ProductService>(); // Register service

//builder.Services.AddScoped<IProductService, ProductService>();
// above one is used when One instance per Http request

//builder.Services.AddTransient<ProductService>();
//A new instance each time it's request

/**

| Lifetime  | Scope                       | Real-time Use Case                     |
| --------- | --------------------------- | -------------------------------------- |
| Singleton | Entire application lifetime | App config, Logger, Cache              |
| Scoped    | One HTTP request            | DB context, Repository, Unit of Work   |
| Transient | Every time requested        | Formatter, GUID generator, EmailSender |

**/
builder.Services.AddTransient<IdGeneratorService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello, Srikanth! Your app is running.");

app.Run();
