using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DrivingCourses.Core.ViewModels.PageViewModels;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace DrivingCourses.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {

            //if (appConfigRepository.Get().IsUserLogedIn)
            //{
            //    return NavigationHelper.ShowMain(NavigationService, new MvxAsyncCommand(startupUpdater.UpdateAll));
            //}
            //else
            //{
                return NavigationService.Navigate<MainViewModel>();
            //}
        }

     
    }
}
