using AEHKLMNSTZDotNetCore.RestApi;
using Microsoft.EntityFrameworkCore;
using Serilog.Sinks.MSSqlServer;
using Serilog;

#region Serilog
Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.File("logs/RestApiLog_.txt", rollingInterval: RollingInterval.Hour)
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

#region Serilog
builder.Host.UseSerilog();
#endregion

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
},
ServiceLifetime.Transient,
ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
