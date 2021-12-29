using EAndSSolutions.BAL.IService;
using EAndSSolutions.BAL.Service;
using EAndSSolutions.Common.AutoMapper;
using EAndSSolutions.DAL.IRepository;
using EAndSSolutions.DAL.Repository;
using EAndSSolutions.Entity.Context;
using EAndSSolutions.Model.Model.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace API_EAndSSolutions.ExtensionMethod
{
    public static class AddServiceDependency
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

           // services.AddControllers()
           //.AddJsonOptions(options =>
           //{
           //    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
           //});


            services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IMasterDataService, MasterDataService>();
            services.AddTransient<IMasterDataRepository, MasterDataRepository>();


            services.AddDbContext<EAndSSolutionsContext>(db => db.UseSqlServer(configuration.GetConnectionString("CoreWebAPI"))
                                                       // .EnableSensitiveDataLogging(true)
                                                       , ServiceLifetime.Scoped);
            services.AddAutoMapper(typeof(AutoMapperRequestProfile));

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])) //Configuration["JwtToken:SecretKey"]  
                };
            });

            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo { Title = "EAndSSolutions Web API", Version = "v1" });
                swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
            });
        }
    }
}
