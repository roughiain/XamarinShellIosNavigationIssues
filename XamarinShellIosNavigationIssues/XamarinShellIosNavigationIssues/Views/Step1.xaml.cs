using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinShellIosNavigationIssues.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step1 : ContentPage
    {
        public Step1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(Step2)}");
        }
    }
}