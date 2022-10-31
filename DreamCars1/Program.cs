using DreamCars1.Models;
using DreamCars1.Services;
using System.Text.Json;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;







var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<JsonCarFile>(); //we have to add service here.....

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints => //error solved by bilal
{
    endpoints.MapGet("/CarRecord", (context) =>
    {
        IEnumerable<Car> CarRecord = app.Services.GetRequiredService<JsonCarFile>().getCarsData();
        var JsonCarRecord = JsonSerializer.Serialize(CarRecord); //conversion to string
        return context.Response.WriteAsync(JsonCarRecord);
    });
});

app.Run();
