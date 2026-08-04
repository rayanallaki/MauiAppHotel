using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("GermaniaOne-Regular.ttf", "GermaniaOne");
                    fonts.AddFont("BebasNeue-Regular.ttf", "BebasNeue");
                    fonts.AddFont("GoogleSans-Italic-VariableFont_GRAD,opsz,wght.ttf", "Italic");
                    fonts.AddFont("GoogleSans-VariableFont_GRAD,opsz,wght.ttf", "GoogleSans-VariableFont_GRAD");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
