using System;
using TRIGEERS_MVVM_IESR.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRIGEERS_MVVM_IESR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcategoria();

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
