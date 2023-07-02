using DotaPlayerData.API;
using DotaPlayerData.Core;
using Microsoft.Extensions.Logging;

namespace DotaPlayerData.UI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddScoped<IOpenDotaApiClient, OpenDotaApiClient>();
        builder.Services.AddScoped<IHeroService, HeroService>();

        return builder.Build();
    }
}