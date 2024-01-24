using AEHKLMNSTZDotNetCore.MvcApp.EFDbContext;
using AEHKLMNSTZDotNetCore.MvcApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using RestSharp;
using Serilog;
using Serilog.Sinks.MSSqlServer;

#region Serilog
Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.File("logs/MvcAppLog_.txt", rollingInterval: RollingInterval.Hour)
                    .WriteTo
                    .MSSqlServer(
                             connectionString: "Server=.;Database=TestDb;User ID=sa;Password=sa@123;Trust Server Certificate=True;",
                             sinkOptions: new MSSqlServerSinkOptions
                             {
                                 TableName = "LogEvents",
                                 AutoCreateSqlTable = true,
                             }
                                )
                    .CreateLogger();
#endregion

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Serilog
builder.Host.UseSerilog();
#endregion

builder.Services.AddDbContext<AppDbContext>(options =>
{
    string? connectionString = builder.Configuration.GetConnectionString("DbConnection");
    options.UseSqlServer(connectionString);
},
ServiceLifetime.Transient,
ServiceLifetime.Transient);

#region Refit

builder.Services
    .AddRefitClient<IBlogApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration.GetSection("RestApiUrl").Value!));

#endregion

#region HttpClient

//builder.Services.AddScoped<HttpClient>();
builder.Services.AddScoped(x => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("RestApiUrl").Value!)
});

#endregion

#region RestClient

builder.Services.AddScoped(x => new RestClient(builder.Configuration.GetSection("RestApiUrl").Value!));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
