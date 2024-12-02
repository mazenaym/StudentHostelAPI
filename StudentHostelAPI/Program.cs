
using Microsoft.EntityFrameworkCore;
using StudentHostel.DAL.Database;
using StudentHostel.DAL.Repository.IRepository;
using StudentHostel.DAL.Repository;
using StudentHostel.BLL.Service.IService;
using StudentHostel.BLL.Service;

namespace StudentHostelAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(
              (options) =>
              {
                  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
              }

                   );
            ////repo
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();
            builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();
            //service
            builder.Services.AddScoped<IStudentService,StudentService>();
            builder.Services.AddScoped<IOwnerService,OwnerService>();
            builder.Services.AddScoped<IApartmentService,ApartmentService>();
            builder.Services.AddScoped<ICommentService,CommentService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
