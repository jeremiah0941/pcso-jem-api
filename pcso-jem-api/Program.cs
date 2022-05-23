using pcso_jem_api;

var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();

     MessageManager messageManager = new MessageManager();    

    app.MapGet("Hello", () => "Hello jem");
    app.MapGet("Product", () => "hey");

    app.MapPost("Product", (Product p) => "Product saved in SQL");
    app.MapDelete("Product", (string name) => "Deleted");

    app.MapPost("Chat", (Message msg) => messageManager?.Messages?.Add(msg));
    app.MapGet("Chat", () => messageManager?.Messages);

app.Run();

//Some Data Contracts
public record class Message(string Name, string Msg);
public record class Product(string Name, string Picture, int Price);