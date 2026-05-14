// using Portal.Common.Mapper;
using MediatR;
using Portal.Application.Common;
using Portal.Infrastructure;
// using Microsoft.AspNetCore.SpaServices.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();
string sqlConnectionString = configuration["AppSettings:MSSQL:SqlconnectionString"] ?? throw new InvalidOperationException("Connection string not found in configuration.");

builder.Services.AddCors(options =>
{
    options.AddPolicy("DevCorsPolicy", policy =>
    {
        policy
            .WithOrigins("http://localhost:4200",
             "https://zwebsl.com",
            "https://www.zwebsl.com")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddInfrastructure(sqlConnectionString);
builder.Services.AddWebsiteAudit();
builder.Services.AddMediatR(typeof(ApplicationAssemblyMarker).Assembly);
builder.Services.AddSwaggerGen();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseCors("DevCorsPolicy");
}
app.UseCors("DevCorsPolicy");


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseStaticFiles();


// app.UseSpa(spa =>
// {
//     spa.Options.SourcePath = "../Portal.Frontend";
//     if (app.Environment.IsDevelopment())
//     {
//        spa.UseAngularCliServer(npmScript: "start");
//     }
// });


app.Run();
