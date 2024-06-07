using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.EntityFreamework;
using DataAccsessLayer.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//catching constructer
builder.Services.AddScoped<IServiceService,ServiceManager>();
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddDbContext<AgricultureContext>();

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