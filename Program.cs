using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Fanca_Loredana_Madalina.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Fanca_Loredana_MadalinaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Fanca_Loredana_MadalinaContext") ?? throw new InvalidOperationException("Connection string 'Fanca_Loredana_MadalinaContext' not found.")));

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

app.Run();
