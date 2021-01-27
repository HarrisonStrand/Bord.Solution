using BordAPI.Models;
using BordAPI.Helpers;
// using BordAPI.Services;
using BordAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace BordAPI
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
      services.AddCors();
      services.AddDbContext<BordAPIContext>(opt =>
        opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
        .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
      services.AddAutoMapper();

      // //configure strongly typed settings objects
      // var appSettingsSection = Configuration.GetSection("AppSettings");
      // services.Configure<AppSettings>(appSettingsSection);

      //configure jwt authentication
      // var appSettings = appSettingsSection.Get<ApiExplorerSettingsAttribute>();
      // var key = Encoding.ASCII.GetBytes(appSettings.Secret);
      // services.AddAuthentication(x =>
      // {
      //   x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
      //   x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
      // })
      // .AddJwtBearer(x =>
      // {
      //   x.Events = new JwtBearerEvents
      //   {
      //     OnTokenValidated = _db =>
      //     {
      //       var userService = _db.HttpContext.RequestServices.GetRequiredService<ISupportRequiredService>();
      //       var userId = int.Parse(_db.Principal.Identity.Name);
      //       var user = userService.GetById(userId);
      //       if (user == null)
      //       {
      //         //return unauthorized if user no longer exists
      //         _db.Fail("Unauthorized");
      //       }
      //       return Task.CompletedTask;
      //     }
      //   };
      //   x.RequireHttpsMetadata = false;
      //   x.SaveToken = true;
      //   x.TokenValidationParameters = new TokenValidationParameters
      //   {
      //     ValidateIssuerSigningKey = true,
      //     IssuerSigningKey = new SymmetricSecurityKey(key),
      //     ValidateIssuer = false,
      //     ValidateAudience = false
      //   };
      // });
      // // configure DI for application services
      // services.AddScoped<IUserService, UserService>();

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseCors(x => x
      .AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader());

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseAuthentication();

      //app.UseHttpsRedirection();
      app.UseMvc();
    }
  }
}
