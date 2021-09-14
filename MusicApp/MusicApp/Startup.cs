using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicApp.DataAccess;
using MusicApp.DataAccess.Repositories;
using MusicApp.Domain.Models;
using MusicApp.Services;

namespace MusicApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<MusicAppDbContext>
                (
                    x => x.UseSqlServer("Server=BTL-LJUBE-BAJR1\\SQLEXPRESS;Database=MusicAppDb;Trusted_Connection=True")
                );

            services.AddTransient<IRepository<AccountType>, AccountTypeEntityRepository>();
            services.AddTransient<IRepository<User>, UserEntityRepository>();
            services.AddTransient<IRepository<Song>, SongEntityRepository>();
            services.AddTransient<IRepository<Playlist>, PlaylistEntityRepository>();

            services.AddTransient<IAccountTypeService, AccountTypeService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISongService, SongService>();
            services.AddTransient<IPlaylistService, PlaylistService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
