using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yoton
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new PageAccueil() );
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
