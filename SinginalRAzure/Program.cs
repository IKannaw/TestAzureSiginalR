var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR().AddAzureSignalR("Endpoint=https://insightlab1.service.signalr.net;AccessKey=tzbP65DB+F7aHHSvVkkarHi2NIbFa3KQMaR1sGfuxV8=;Version=1.0;"); 

var app = builder.Build();

app.UseDefaultFiles();
app.UseRouting();
app.UseStaticFiles();
app.MapHub<ChatSampleHub>("/chat");
app.Run();
