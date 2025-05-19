
using ApiPresidenciaDR.Application_Layer.Dlls.ScadaDlls;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.GeneracionUltimas24HorasDto;
using ApiPresidenciaDR.Controllers;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using static System.Net.WebRequestMethods;

namespace ApiPresidenciaDR
{
    public class Program
    {
        private const string IdentityConnectionString = "Identity";
        private const string JwtAuthority = "https://duendeserveregehid.azurewebsites.net/";
        private const string JwtAudience = "9fc33c2e-dbc1-4d0a-b212-68b9e07b3ba0";
        private const string ApiScope = "https://www.example.com/api";
        private const string TokenUrl = "https://duendeserveregehid.azurewebsites.net/connect/token";

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ScadaDataContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString(IdentityConnectionString), sqlOptions => sqlOptions.CommandTimeout(180)));
            builder.Services.AddScoped<IScadaRepository, ScadaRepository>();
            builder.Services.AddScoped<PotenciaUltimas24HorasScadaDLL>();
            builder.Services.AddScoped<NivelesScadaDLL>();
            builder.Services.AddScoped<GeneracionScadaDLL>();
            builder.Services.AddScoped<Generacion24hAsyncController>();
            builder.Services.AddScoped<Niveles6MesesAsyncController>();
            builder.Services.AddScoped<Niveles6MesesScadaDLL>();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddDbContext<scadadbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString(IdentityConnectionString)));

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(jwtBearerOptions =>
                {
                    jwtBearerOptions.Authority = JwtAuthority;
                    jwtBearerOptions.Audience = JwtAudience;
                    jwtBearerOptions.RequireHttpsMetadata = false;
                });

            builder.Services.AddAuthorization(authorizationOptions =>
            {
                authorizationOptions.AddPolicy("ApiScope", authorizationPolicyBuilder =>
                {
                    authorizationPolicyBuilder.RequireAuthenticatedUser().RequireClaim("scope", ApiScope);
                });
            });

            builder.Services.AddHttpClient();
            builder.Services.AddRazorPages();
            builder.Services.AddControllers();
            builder.Services.AddCors(corsOptions =>
            {
                corsOptions.AddDefaultPolicy(corsPolicyBuilder =>
                {
                    corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(swaggerGenOptions =>
            {
                swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

                swaggerGenOptions.AddSecurityDefinition("oauth2",
                    new OpenApiSecurityScheme
                    {
                        Type = SecuritySchemeType.OAuth2,
                        Flows = new OpenApiOAuthFlows
                        {
                            ClientCredentials = new OpenApiOAuthFlow
                            {
                                TokenUrl = new Uri(TokenUrl),
                                Scopes = { { ApiScope, "API" } }
                            }
                        }
                    });

                swaggerGenOptions.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                            },
                            new List<string> { ApiScope }
                        }
                });
            });

            builder.Services.AddOutputCache(options =>
            {
                options.AddBasePolicy(builder => builder.Expire(TimeSpan.FromSeconds(60)));
                options.AddPolicy("ExpireIn30s", builder => builder.Expire(TimeSpan.FromSeconds(30)));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            else
            {
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("An unexpected fault happened. Try again later.");
                    });
                });
            }

            app.UseOutputCache();
            app.UseHttpsRedirection();
            app.UseCors();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}