using Microsoft.Extensions.DependencyInjection;
using SimplyWorks_UtilityMeasurement.Maui.Services;

namespace SimplyWorks_UtilityMeasurement.Maui
{
    public partial class App : Application
    {
        public App(DbInitializer dbInit)
        {
            InitializeComponent();
            MainPage =new AppShell();
            _ = InitializeAsync(dbInit);
        }

        private static async Task InitializeAsync(DbInitializer dbInit)
        {
            try { await dbInit.InitializeAsync(); }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex); }
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}