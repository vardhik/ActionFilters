using FiltersExtension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages()
        .AddMvcOptions(options =>
        {
            options.Filters.Add(new CustomeExceptionfilters());
        });
//OR
//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services); // calling ConfigureServices method
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
app.MapRazorPages();
app.Run();
//OR 
//startup.Configure(app, builder.Environment); // calling Configure method


//public class Startup
//{
//    public IConfiguration configRoot
//    {
//        get;
//    }
//    public Startup(IConfiguration configuration)
//    {
//        configRoot = configuration;
//    }
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddRazorPages();
//    }
//    public void Configure(WebApplication app, IWebHostEnvironment env)
//    {
//        if (!app.Environment.IsDevelopment())
//        {
//            app.UseExceptionHandler("/Error");
//            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//            app.UseHsts();
//        }
//        app.UseHttpsRedirection();
//        app.UseStaticFiles();
//        app.UseRouting();
//        app.UseAuthorization();
//        app.MapRazorPages();
//        app.Run();
//    }
//}