using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinShellIosNavigationIssues.Services;
using XamarinShellIosNavigationIssues.Views;

namespace XamarinShellIosNavigationIssues
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
           await Shell.Current.GoToAsync($"//{nameof(Step1)}");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
