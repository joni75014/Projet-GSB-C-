﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetGsb
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //pour permettre à la page principale de naviguer
            MainPage = new NavigationPage (new MainPage());
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
