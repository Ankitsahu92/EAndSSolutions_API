using API_EAndSSolutions.ExtensionMethod;
using API_EAndSSolutions.Filters;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterServices();
builder.Services.AddControllers();
//.AddJsonOptions(
//    o =>
//    {
//       // o.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
//        o.JsonSerializerOptions.WriteIndented = true;
//    }
//    );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseMiddleware<JwtMiddleware>();

app.MapControllers();

app.Run();
