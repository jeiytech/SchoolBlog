using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace SchoolBlog;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit MediaElement by adding the below line of code
            .UseMauiCommunityToolkitMediaElement()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("fa-brands-400.ttf", "FaBrands");
				fonts.AddFont("fa-regular-400.ttf", "FaRegular");
				fonts.AddFont("fa-solid-900.ttf", "FaSolid");
				fonts.AddFont("material-design-iconic-font.min.css", "MaterialDesign");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
