using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

//builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.WebHost.ConfigureKestrel((context, serverOptions) => {
    serverOptions.Listen(IPAddress.Loopback,25301);
});

var app = builder.Build();

app.MapRazorPages();

app.UseStatusCodePagesWithReExecute("/error/{0}");

app.Run();
