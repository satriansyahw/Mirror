
using GenHelper.Cache;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using WebApi.Controllers.General;

namespace WebApi
{
    public class Startup
    {
        private readonly string mirrorCORS = "MirrorCORS";
        private readonly string msgUnotorise = "Sorry, you're dont have any authorize !";
        private readonly StartupSetting startupSetting = StartupSetting.GetInstance;
        private readonly MemoryCacher cacher = MemoryCacher.GetInstance;
        private readonly ITokenBuild token = TokenBuild.GetInstance;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddResponseCompression();

            /*For setting later please check to Manager.KeyStorage*/
           // services.Configure<APISetting>(Configuration.GetSection("APISettings"));
            string TokenKey = Configuration.GetSection("APISettings:TokenKey").Value;
            string TokenIssuer = Configuration.GetSection("APISettings:TokenIssuer").Value;
            string TokenAudience = Configuration.GetSection("APISettings:TokenAudience").Value;
            string TokenAlgo = Configuration.GetSection("APISettings:TokenAlgo").Value;
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = startupSetting.FormOptionValueLength;
                x.MultipartBodyLengthLimit = startupSetting.FormOptionsBodyLength;
                x.MultipartHeadersLengthLimit = startupSetting.FormOptionsHeaderLength;
            });

            string[] allowedOrigin = { "http://localhost:61138/" };
            services.AddCors(options =>
            {
                options.AddPolicy(this.mirrorCORS,
                    builder =>
                    {

                        var allowedDomains = new[] { "http://localhost:61138/" };
                        builder.AllowAnyHeader();
                        builder.AllowAnyOrigin();
                        //builder.WithOrigins(allowedOrigin);
                        builder.AllowAnyMethod();
                        builder.AllowCredentials();
                        builder.SetPreflightMaxAge(TimeSpan.FromSeconds(2520));
                    });
            });
            var tokenValidationParameters = new TokenValidationParameters
            {


                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = TokenIssuer,
                ValidAudience = TokenAudience,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(TokenKey)),
                ClockSkew = TimeSpan.Zero
            };
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
             .AddJwtBearer(options =>
             {
                 options.TokenValidationParameters = tokenValidationParameters;
                 options.Events = new JwtBearerEvents()
                 {

                     OnTokenValidated = context =>
                     {
                         string identityName = context.Principal.Identity.Name;
                         JwtSecurityToken accessToken = context.SecurityToken as JwtSecurityToken;
                         bool isTokenCheck = token.SecurityTokenVerification(accessToken);
                         if (isTokenCheck)
                         {
                             bool checkResult = true;// put your logic in checkResult variable
                             if (!checkResult) context.Fail(this.msgUnotorise);
                             return Task.CompletedTask;
                         }
                         else
                         {
                             context.Fail(this.msgUnotorise);
                             return Task.CompletedTask;
                         }
                     }
                      ,
                     OnAuthenticationFailed = context =>
                     {

                         context.Fail("OnAuthenticationFailed: " +
                             context.Exception.Message);
                         return Task.CompletedTask;
                     }

                 };
                 options.SaveToken = true;

             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseHsts();
            //}

           // app.UseHttpsRedirection();
            app.UseMvc();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCors(mirrorCORS);
            app.UseResponseCompression();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run(async (context) =>
            {

                string div = "<div style='display:table;width:100%;height:100%;'>"
               + "<div style='display:table-cell;vertical-align:middle;text-align:center;color:white;font-weight:bold '>"
                + "<label style='font-family:Segoe Script;font-size:40px;font-weight:bold'> Hi Mirror Catch Me If You Can</label><br/>"
                + "<label style='font-size:20px'api </label>"
                + "</div>"
                + "</div>";

                string body = "<div style='position:absolute;width:100%;height:100%;left:0px;top:0px;background-color:gray'>" + div + "</div>";

                await context.Response.WriteAsync(body);

            });

        }
        
    }
}
