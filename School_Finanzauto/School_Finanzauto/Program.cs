using School_Finanzauto.Extensions;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DataBase");
// Add services to the container.
builder.Services.AddControllers();
builder.Services.ConfigureDependencyInjection();
builder.Services.ConfigureDataBaseConnection(connectionString);
builder.Services.ConfigureCors();
builder.Services.AddControllers();
builder.Services.ConfigureMapSectionConfiguration(builder.Configuration);
builder.Services.ConfigureAuthentication(builder.Configuration);
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

app.UseErrorHanldinMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
