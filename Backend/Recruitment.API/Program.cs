var builder = WebApplication.CreateBuilder(args);
var app=builder.Build();
app.MapGet("/",()=>"Recruitment API");
app.Run();