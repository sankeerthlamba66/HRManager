
using HRManager.Business;
using HRManager.Business.BussinessRepository;
using HRManager.Data.Entity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
HRManager.Code.DBSetup.IntializeConfig(builder);
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<Context>(options => options.UseSqlServer("Data Source=tekfriday122;Database=HRManager;User ID=sa;Password=friday123!"));
builder.Services.AddScoped<IAdminManager,AdminManager>();
builder.Services.AddScoped<IEmployeeManager,EmployeeManager>();
builder.Services.AddScoped<ILoginManager,LoginManager>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
