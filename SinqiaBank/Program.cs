using SinqiaBankHiringProccess.Controllers;
using SinqiaBankHiringProccess.Application.Services;
using SinqiaBankHiringProccess.Core.Observers;
using SinqiaBankHiringProccess.Core.Validators;

namespace SinqiaBankHireTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IUserValidator, UserValidator>();
            builder.Services.AddTransient<IOrderService, OrderService>();

            // Registra o EventNotifier como Singleton
            builder.Services.AddSingleton<IObservable, EventNotifier>();

            // Registra os Observers
            builder.Services.AddSingleton<OrderObserver>();

            // Registra os controllers como Singleton
            //builder.Services.AddSingleton<UserController>();
            //builder.Services.AddSingleton<OrderController>();
            //builder.Services.AddSingleton<ProductController>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Inscrevendo os Observadores
            var notifier = app.Services.GetRequiredService<IObservable>();
            notifier.Subscribe(app.Services.GetRequiredService<OrderObserver>());

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
        }
    }
}