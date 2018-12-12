using System;
using DrivingCourses.Core.ViewModels.PageViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DrivingCouses.Views;
using MvvmCross.IoC;

namespace DrivingCouses
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
