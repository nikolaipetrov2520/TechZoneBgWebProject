namespace TechZoneBgWebProject.Web
{
    using System.Reflection;

    using AutoMapper;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    using TechZoneBgWebProject.Data;
    using TechZoneBgWebProject.Data.Common;
    using TechZoneBgWebProject.Data.Common.Repositories;
    using TechZoneBgWebProject.Data.Models;
    using TechZoneBgWebProject.Data.Repositories;
    using TechZoneBgWebProject.Data.Seeding;
    using TechZoneBgWebProject.Services.Brands;
    using TechZoneBgWebProject.Services.Carts;
    using TechZoneBgWebProject.Services.Categories;
    using TechZoneBgWebProject.Services.Checks;
    using TechZoneBgWebProject.Services.Conditions;
    using TechZoneBgWebProject.Services.Devices;
    using TechZoneBgWebProject.Services.Mapping;
    using TechZoneBgWebProject.Services.Messages;
    using TechZoneBgWebProject.Services.Messaging;
    using TechZoneBgWebProject.Services.Posts;
    using TechZoneBgWebProject.Services.Products;
    using TechZoneBgWebProject.Services.Providers;
    using TechZoneBgWebProject.Services.Reactions;
    using TechZoneBgWebProject.Services.Replies;
    using TechZoneBgWebProject.Services.Reports;
    using TechZoneBgWebProject.Services.Roles;
    using TechZoneBgWebProject.Services.Statuses;
    using TechZoneBgWebProject.Services.Tags;
    using TechZoneBgWebProject.Services.Users;
    using TechZoneBgWebProject.Web.Hubs;
    using TechZoneBgWebProject.Web.Infrastructure.Extensions;
    using TechZoneBgWebProject.Web.ViewModels;

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<CookiePolicyOptions>(
                options =>
                    {
                        options.CheckConsentNeeded = context => true;
                        options.MinimumSameSitePolicy = SameSiteMode.None;
                    });

            services.AddControllersWithViews(
                options =>
                    {
                        options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                    }).AddRazorRuntimeCompilation();
            services.AddRazorPages();
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddSingleton(this.configuration);

            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IDbQueryRunner, DbQueryRunner>();

            services.AddTransient<IPostsService, PostsService>();
            services.AddTransient<IReactionsService, ReactionsService>();
            services.AddTransient<IReplyReactionsService, ReplyReactionsService>();
            services.AddTransient<ITagsService, TagsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IRepliesService, RepliesService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<IReplyReportsService, ReplyReportsService>();
            services.AddTransient<IMessagesService, MessagesService>();
            services.AddTransient<IDateTimeProvider, DateTimeProvider>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<IProductsService, ProductsService>();
            services.AddTransient<ICartsService, CartsService>();
            services.AddTransient<IDevicesService, DevicesService>();
            services.AddTransient<IBrandsService, BrandsService>();
            services.AddTransient<IConditionsService, ConditionsService>();
            services.AddTransient<IChecksService, ChecksService>();
            services.AddTransient<IStatusesService, StatusesService>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new TechZoneBgProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();

            services.AddTransient<IEmailSender>(
                serviceProvider => new SendGridEmailSender(this.configuration["SendGrid:ApiKey"]));
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
                new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

            app.SeedData();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStatusCodePagesWithRedirects("/Home/NotFound{0}");
            app.UseEndpoints(
                endpoints =>
                    {
                        endpoints.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                        endpoints.MapControllerRoute("default", "{controller=Products}/{action=All}/{id?}");
                        endpoints.MapHub<ChatHub>("/chat");
                        endpoints.MapRazorPages();
                    });
        }
    }
}
