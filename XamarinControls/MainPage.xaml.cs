using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnCommonControls.Clicked += GoToCommonControlsPage;
            btnTextControls.Clicked += GoToTextControlsPage;
            btnListControls.Clicked += GoToListControlsPage;
        }

        private async void GoToListControlsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListControls());
        }

        private async void GoToTextControlsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextControls());
        }

        private async void GoToCommonControlsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonControls());
        }
    }
}
