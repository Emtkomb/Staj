using ToDo.BusinessLayer.Abstract;
using ToDo.BusinessLayer.Concrete;
using ToDo.DataAccessLayer.Abstract;
using ToDo.DataAccessLayer.Concrete;
using ToDo.DataAccessLayer.EntityFramework;
using ToDo.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddScoped<IToDoDal,EfToDoDal>();
builder.Services.AddScoped<IToDoService,TodoManager>();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("ToDoApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
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
app.UseCors("ToDoApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
