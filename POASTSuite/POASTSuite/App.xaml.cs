﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace POASTSuite
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
          //  DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new PoastMainPage());
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
