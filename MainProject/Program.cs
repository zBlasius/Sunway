using MainProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var hotelService = new HotelService();

app.MapGet(
        "/hotels",
        () =>
        {
            try
            {
                var list = hotelService.GetList();
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.Problem("An unexpected error occurred.", statusCode: 500);
            }
        }
    )
    .WithName("GetHotelList");
app.MapGet(
        "/hotels/{id}",
        (string id) =>
        {
            try
            {
                if (!int.TryParse(id, out var numericId))
                {
                    return Results.NotFound(new { error = "id must to be a number" });
                }

                var hotel = hotelService.GetById(id);

                if (hotel == null)
                {
                    return Results.NotFound(new { error = "Hotel not found" });
                }

                return Results.Ok(hotel);
            }
            catch (Exception ex)
            {
                // Here would be interesting implement a log tool. I would use RabbitMQ to dispatch a task and inside this task I would
                // register the log in some tool, platform or database.
                Console.WriteLine($"Error: {ex.Message}");
                return Results.Problem("An unexpected error occurred.", statusCode: 500);
            }
        }
    )
    .WithName("GetHotelById");

app.Run();
