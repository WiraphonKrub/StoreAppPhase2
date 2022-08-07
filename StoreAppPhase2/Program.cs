using StoreAppPhase2.DbContexts;
using StoreAppPhase2.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

AddServices(builder);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//ReCreateDatabase(app);
app.Run();



void AddServices(WebApplicationBuilder builder)
{
    // Add services to the container.

    builder.Services.AddControllers();
    builder.Services.AddDbContext<DataContext>(options =>
    {
        options.UseSqlServer(@"Data Source=localhost;Initial Catalog=StoreAppPhase2;Persist Security Info=True;User ID=SA;Password=MyPass@word;Max Pool Size=20000;");
        options.EnableSensitiveDataLogging(true);

    });
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    builder.Services.AddScoped<IDataReposity, DataRepository>();
    builder.Services.AddControllers().AddJsonOptions(j =>
    {
        j.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

}

void ReCreateDatabase(WebApplication app)
{
    using (var scope = app.Services.CreateScope())
    {

        try
        {
            var context = scope.ServiceProvider.GetService<DataContext>();
            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }
        catch (Exception ex)
        {
            var logger = scope.ServiceProvider.GetService<ILogger>();
            logger.LogError(ex, "Error happens when migrations the database.");
        }

    }
}