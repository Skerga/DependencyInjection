using Godot;
using System;
using Godot.DependencyInjection;
using Microsoft.Extensions.Logging;

public partial class Main : Node
{
    private readonly ILogger<Main> _logger;

    [Inject]
    public Main(ILogger<Main> logger)
    {
        _logger = logger;
    }

    public override void _Ready()
    {
        _logger.LogInformation("Hello World!");
    }
}
