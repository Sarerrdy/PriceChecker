using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using PriceChecker.Models;
using PriceChecker.Models.Context;
using PriceChecker.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPriceCheckerRepository, PriceCheckerRepository>();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<PriceCheckerContext>(cfg =>
                    cfg.UseSqlServer(builder.Configuration.GetConnectionString("PriceCheckerConnectionString")));

builder.Services.AddControllers(
    options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

builder.Services.AddTransient<PriceCheckerSeeder>();
builder.Services.AddMvc()
    .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); ;

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();



if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        var seeder = scope.ServiceProvider.GetRequiredService<PriceCheckerSeeder>();
        await seeder.Seed();
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
