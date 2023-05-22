using Pomoday.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Configuração de conexão com o banco
var connectionString = Environment.GetEnvironmentVariable("POMODAY_CONNSTRING");
NativeInjectorBootStrapper.RegisterAppDependenciesContext(builder.Services, connectionString);
#endregion

#region Configuração services e mappers
NativeInjectorBootStrapper.RegisterAppDependencies(builder.Services);
#endregion
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
