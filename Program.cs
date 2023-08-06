using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using connect_four__server.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();  // allow mvc services
builder.Services.AddRazorPages();
builder.Services.AddDbContext<connect_four__serverContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connect_four__serverContext") ?? throw new InvalidOperationException("Connection string 'connect_four__serverContext' not found.")));

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

//Adding MVC Middleware
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    //Configuring the MVC middleware to the request processing pipeline
    endpoints.MapDefaultControllerRoute();
});

app.UseAuthorization();

app.MapRazorPages();

app.Run();
