using Microsoft.AspNetCore.Components;

namespace testBT
{
    public partial class App : Application
    {
        InterfaceAPI api;
        NavigationManager navigationManager;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override async void OnSleep()
        {
            await api.Logout();
            navigationManager.NavigateTo("/login");

        }
    }
}
