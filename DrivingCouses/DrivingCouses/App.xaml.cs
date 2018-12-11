using System;
using DrivingCourses.Core.ViewModels.PageViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DrivingCouses.Views;
using MvvmCross.IoC;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DrivingCouses
{
    public partial class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
            // if you want to use a custom AppStart, you should replace the previous line with this one:
            // RegisterCustomAppStart<MyCustomAppStart>();
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
