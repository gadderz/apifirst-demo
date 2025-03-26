var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi("v1", (c) => {
    c.ShouldInclude = (desc) => desc.GroupName == "v1";
});
builder.Services.AddOpenApi("v2", (c) => {
    c.ShouldInclude = (desc) => desc.GroupName == "v1" || desc.GroupName == "v2";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // app.UseSwaggerUI(opts => opts.SwaggerEndpoint("/openapi/v1.json", "Api First Demo V1"));
    app.UseSwaggerUI(opts => opts.SwaggerEndpoint("/openapi/v2.json", "Api First Demo V2"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
