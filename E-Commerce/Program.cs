using E_Commerce.Core.Repository.CrossCuttingRepository;
using E_Commerce.Core.Services.CompanyServ;
using E_Commerce.Core.Services.ProductServ;
using E_Commerce.Repository;
using E_Commerce.Repository.Repositories.CrossCuttingRepository;
using E_Commerce.Services.CompanyServiceImplementation;
using E_Commerce.Services.ProductServiceImplementation;
using Microsoft.EntityFrameworkCore;

    var builder = WebApplication.CreateBuilder(args);


    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    var connectionString = builder.Configuration.GetConnectionString("Default");
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
    {
        options.UseSqlServer(connectionString);
    });

    builder.Services.AddTransient(typeof(ICrossCuttingRepository<>), typeof(CrossCuttingRepository<>));

    builder.Services.AddTransient<ICompanyService, CompanyServices>();
    builder.Services.AddTransient<IProductService, ProductServices>();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
