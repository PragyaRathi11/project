var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//addme


//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<Ecom>(x => x.UseSqlServer(Configuration.GetConnectionString("EcomConection")));

//internal class EcomContext
//{

//}

var app = builder.Build();

//additionalme
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
    //( c =>
//{
  //  c.RoutePrefix = "";
    //c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//});
//
 
//services.AddTransient<IJWTMangerRepository, JWTManagerRepository>();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
