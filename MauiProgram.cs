using Microsoft.Extensions.Logging;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using testBT.Service;
using Microsoft.Maui.Storage;



namespace testBT

{
    public static class MauiProgram
    {
        
        private static interfacePreferences _preferences = new PreferencesService();
        public static MauiApp CreateMauiApp() { 

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            
            builder.Services.AddSingleton<interfacePreferences, PreferencesService>();
            builder.Services.AddSingleton<InterfaceAPI, APIService>();

            builder.Services.AddSingleton<IBluetoothLE>(CrossBluetoothLE.Current);
            builder.Services.AddSingleton<IAdapter>(CrossBluetoothLE.Current.Adapter);
            string baseaddress = Preferences.Get("APIURL",string.Empty);
            builder.Services.AddScoped(Sp => new HttpClient { BaseAddress=new Uri("https://localhost:7117/api/")});

#if DEBUG

            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
