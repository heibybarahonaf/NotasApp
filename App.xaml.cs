using Plugin.Maui.Audio;
using NotasApp.Models;
using NotasApp.Controllers;
using NotasApp.Views;

namespace NotasApp

{
    public partial class App : Application
    {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new PaginaPrincipal(AudioManager.Current));

        }
    }
}
