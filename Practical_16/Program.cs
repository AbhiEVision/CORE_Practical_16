
using System.Runtime.CompilerServices;

namespace Practical_16
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// added Controller Service
			builder.Services.AddControllers();

			// This is not needed Because it will call internally by the .AddControllers() method.
			//builder.Services.AddEndpointsApiExplorer();
			
			// This will Enable the Swagger in Application.
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.

			// setting up the pipeline for Development Purpose.
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