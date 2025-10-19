using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Godot.DependencyInjection
{
    internal partial class DependencyInjection
    {
        static partial void ConfigureHostConfiguration(IConfigurationBuilder configurationBuilder)
        {
            // ...
        }

        static partial void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole());
        }
    }
};