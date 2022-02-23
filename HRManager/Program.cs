
using HRManager.Business;
using HRManager.Business.BussinessRepository;

var builder = WebApplication.CreateBuilder(args);
HRManager.Code.DBSetup.IntializeConfig(builder);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAdminManager,AdminManager>();
builder.Services.AddScoped<IEmployeeManager,EmployeeManager>();
builder.Services.AddScoped<ILoginManager,LoginManager>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllers(
    options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

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
