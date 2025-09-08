var builder = WebApplication.CreateBuilder(args);
//dodawanie pakietow do serwisu

//dodawanie kontrolerow i widokow (mvc)
builder.Services.AddControllersWithViews();
var app = builder.Build();
//dodatkowa konfiguracja naszego serwera
var books = new List<String> {
    "w pustyni i w puszcczy",
    "pan tadeusz",
    "nigga",
};


app.MapDefaultControllerRoute();

app.UseStaticFiles(); //uzywanie plikow statycznych (index.html index.php)
app.MapGet("/", () => "Nigga World!"); //mozesz sie po tym poruszac dopisujac podstrony
app.MapGet("/inny", () => "Nigger World! inny endpoint");
app.MapGet("/books", ()=> books);

app.Run();
