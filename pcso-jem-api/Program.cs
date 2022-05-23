var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();



var app = builder.Build();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();



    app.MapGet("Hello", () => "Hello jem");
    app.MapGet("Product", () => "hey");


app.Run();