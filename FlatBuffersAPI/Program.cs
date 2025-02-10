using System.Collections.Specialized;
using System.Diagnostics;
using System.Text.Json;
using FlatBuffersAPI;
using Google.FlatBuffers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ConserviceContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/create-data", async (ConserviceContext context) =>
{
    var users = await context.Users.Take(1000).ToListAsync();

    foreach (var user in users)
    {
        var builder = new FlatBufferBuilder(1024);

        var project = builder.CreateString(user.Project);
        var state = builder.CreateString(user.State);
        var firstName = builder.CreateString(user.Name);

        FlatBuffersModels.User.StartUser(builder);
        FlatBuffersModels.User.AddUserId(builder, user.UserId);
        FlatBuffersModels.User.AddName(builder, firstName);
        FlatBuffersModels.User.AddProject(builder, project);
        FlatBuffersModels.User.AddState(builder, state);

        var userOffset = FlatBuffersModels.User.EndUser(builder);

        builder.Finish(userOffset.Value);

        var buf = builder.SizedByteArray();

        await context.DataTypeTests.AddAsync(new DataTypeTest()
        {
            Id = Guid.NewGuid(),
            BinaryData = buf,
            JsonData = JsonSerializer.Serialize(user)
        });

    }

    await context.SaveChangesAsync();
    
    return Results.NoContent();
});

app.MapGet("/compare", async (ConserviceContext context) =>
    {
        var dataSet = await context.DataTypeTests.ToListAsync();

        Stopwatch sw = new();
        sw.Start();
        
        foreach (var data in dataSet)
        {
            var json = data.JsonData;
            // Time to deserialize using System.Text.Json
            JsonSerializer.Deserialize<User>(json);
        }
        sw.Stop();

        Console.WriteLine($"Time to serialize using System.Text.Json: {sw.ElapsedMilliseconds}");
        Console.WriteLine("=========================");
        
        sw.Restart();
        // Time to deserialize using FlatBuffers
        foreach (var data in dataSet)
        {
            var buf = data.BinaryData;
            ByteBuffer buffer = new ByteBuffer(buf);
            FlatBuffersModels.User userFlatBuffers = FlatBuffersModels.User.GetRootAsUser(buffer);
        }

        sw.Stop();
        
        Console.WriteLine($"Time to serialize FlatBuffers: {sw.ElapsedMilliseconds}");
            
        return Results.Ok();
    })
    .WithName("Compare");


app.Run();
