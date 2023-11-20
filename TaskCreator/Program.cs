using AutoMapper;
using DotnetWorld.TaskCreator.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskCreator.Application;
using TaskCreator.Application.Contracts;
using TaskCreator.DDD;
using TaskCreator.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<IEfCoreDbContext, TaskCreatorDbContext>(options =>
        {
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        ConfigureApplicationServices(builder.Services);

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
    }
    private static void ConfigureApplicationServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddTransient<IMainTaskService, MainTaskService>();
        services.AddTransient<ISideTaskService, SideTaskService>();
        services.AddTransient<UnitOfWork>();
        services.AddTransient<IRepository<MainTask, int>, Repository<MainTask, int>>();
        services.AddTransient<IRepository<SideTask, int>, Repository<SideTask, int>>();

        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new TaskCreatorApplicationObjectMapper());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}
