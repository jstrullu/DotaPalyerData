

using System.Reflection;
using DotaPlayerData.API;
using DotaPlayerData.API.Configuration;
using DotaPlayerData.API.Impl;
using DotaPlayerData.Core.Services;
using DotaPlayerData.Core.Services.Impl;
using DotaPlayerData.UI.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace DotaPlayerData.UI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.AddAppSettings();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddScoped<IOpenDotaApiClient, OpenDotaApiClient>();
        builder.Services.AddScoped<IHeroService, HeroService>();
        builder.Services.AddScoped<IPlayerService, PlayerService>();
        builder.Services.AddScoped<IStratzApi, StratzApi>();
        builder.Services.AddScoped<ITeamService, TeamService>();
        builder.Services.AddScoped<IMatchService, MatchService>();
        builder.Services.AddScoped<SearchController>();
        builder.Services.AddSingleton(builder.Configuration.GetSection("Stratz").Get<StratzConfiguration>());
        builder.Services.AddSingleton(builder.Configuration.GetSection("OpenDota").Get<OpenDotaConfiguration>());
        return builder.Build();
    }
    
    private static void AddAppSettings(this MauiAppBuilder builder)
    {
        builder.AddJsonSetting("appsettings.json");
// #if DEBUG
//         builder.AddJsonSetting("appsettings.development.json");
// #endif
// #if !DEBUG
//         builder.AddJsonSetting("appsettings.production.json");
// #endif
    }

    private static void AddJsonSetting(this MauiAppBuilder builder, string fileName)
    {
        var config = new ConfigurationBuilder().AddJsonFile(fileName).Build();
        builder.Configuration.AddConfiguration(config);
    }
}