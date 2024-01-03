using ControleContatos.Data;
using ControleContatos.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Server=DESKTOP-FQIJ08P\\SQLEXPRESS;Database=DB_Sistema;User Id=DESKTOP-FQIJ08P\\João Gabriel;Password=23198443;Trusted_Connection=True;Encrypt=False";
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

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
