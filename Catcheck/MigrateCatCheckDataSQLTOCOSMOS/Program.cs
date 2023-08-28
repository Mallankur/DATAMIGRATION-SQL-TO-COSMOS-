using MigrateCatCheckDataSQLTOCOSMOS.Data.MongoConnector;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Entites.MongoInterfaces;
using MigrateCatCheckDataSQLTOCOSMOS.Infrstructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<MongoConnector>(builder.Configuration.GetSection("MongoObject"));
builder.Services.AddScoped<IMigrationServeises, MongoMigrationServeises>();
builder.Services.AddMvc().AddXmlSerializerFormatters();

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
