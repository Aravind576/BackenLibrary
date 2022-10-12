using BackendLibrary.Models;
using BackendLibrary.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<MyLibrarydatabaseSettings>(
                builder.Configuration.GetSection(nameof(MyLibrarydatabaseSettings)));

builder.Services.AddSingleton<IMyLibrarydatabaseSettings>(sp =>
    sp.GetRequiredService<IOptions<MyLibrarydatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
        new MongoClient(builder.Configuration.GetValue<string>("MyLibrarydatabaseSettings:ConnectionString")));

builder.Services.AddScoped<ILibraryServices, LibraryServices>();
//..............................................................................................................


builder.Services.Configure<LoginCredentialsSettings>(
                builder.Configuration.GetSection(nameof(LoginCredentialsSettings)));

builder.Services.AddSingleton<ILoginCredentialsSettings>(sp =>
    sp.GetRequiredService<IOptions<LoginCredentialsSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s =>
        new MongoClient(builder.Configuration.GetValue<string>("LoginCredentialsSettings:ConnectionString")));

builder.Services.AddScoped<ILoginAuthentications, LoginAuthentcations>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
