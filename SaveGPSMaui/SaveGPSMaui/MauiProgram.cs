using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;


namespace SaveGPSMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
             .UseSentry(options =>
             {
                 options.Dsn = "https://a9b06ae04a234bee9568f5a296e87a3a@o4504503705337856.ingest.sentry.io/4504503732994048";
                 options.Debug = true;
                 options.TracesSampleRate = 1.0;
             })
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
            .UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

