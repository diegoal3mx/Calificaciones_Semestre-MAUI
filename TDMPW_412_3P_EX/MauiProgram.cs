using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace TDMPW_412_3P_EX;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
                fonts.AddFont("SchoolYard-Regular.otf", "School");
                fonts.AddFont("Luxschool.ttf", "LuxSchool");
                fonts.AddFont("FunSchool.ttf", "FunSchool");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
