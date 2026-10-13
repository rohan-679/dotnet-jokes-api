var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Joke[] jokes =
[
    new(1, "Why do programmers prefer dark mode?", "Because light attracts bugs."),
    new(2, "Why did the developer go broke?", "Because they used up all their cache."),
    new(3, "How many programmers does it take to change a light bulb?", "None, that's a hardware problem."),
    new(4, "Why do C# developers wear glasses?", "Because they can't C#."),
    new(5, "What's a programmer's favourite hangout place?", "Foo Bar."),
    new(6, "Why was the JavaScript developer sad?", "Because they didn't Node how to Express themselves."),
];

app.MapGet("/joke", () => jokes[Random.Shared.Next(jokes.Length)]);

app.Run();

record Joke(int Id, string Setup, string Punchline);
