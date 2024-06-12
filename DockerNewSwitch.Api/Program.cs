using DockerNewSwitch.DataService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//pega a string de conexão usando essa GetConnectionString
var connectionString = builder.Configuration.GetConnectionString(name: "DefaultConnection");

// iniciando a DBContext na Injeção de dependencias 
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)
);



// Add services to the container.
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


app.Run();
