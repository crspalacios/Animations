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
            if (box.AnimationIsRunning("FadeTo"))
            {
                return;
            }
            await box.RelRotateTo(1.5);

        }
    }
}
