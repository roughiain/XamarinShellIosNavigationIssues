using System.ComponentModel;
using Xamarin.Forms;
using XamarinShellIosNavigationIssues.ViewModels;

namespace XamarinShellIosNavigationIssues.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}