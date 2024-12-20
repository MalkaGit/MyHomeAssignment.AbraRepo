using LoansLib.BL.Interfaces;
using LoansLib.BL.Services;
using LoansLib.Data.Interfaces;
using LoansLib.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);



//My added to fix Cors. As a result server send in reponse this header: access-control-allow-origin:
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        //policy.WithOrigins("http://localhost:3000/") //react app
        policy.AllowAnyOrigin() //Temp: any react app
        .AllowAnyHeader()
        .AllowAnyMethod());
});



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//My Register services
//note: AddControllers handle the logging
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<ILoanStrategyFactory, LoanStrategyFactory>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<ILoanService, LoanService>();



var app = builder.Build();


//MY
app.UseCors("AllowReactApp");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
