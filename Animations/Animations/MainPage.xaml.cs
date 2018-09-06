using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Animations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void AnimateClicked(object sender, EventArgs e)
        {
            await box.FadeTo(0);
            await box.FadeTo(1);
        }
    }
}
