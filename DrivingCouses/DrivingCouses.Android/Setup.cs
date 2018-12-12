using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DrivingCourses.Core;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;

namespace DrivingCouses.Droid
{
    public class Setup : MvxFormsAndroidSetup<AppSetup, App>
    {
        protected override void InitializeFirstChance()
        {
            //Mvx.IoCProvider.RegisterSingleton<IConnectionFactory>(new ConnectionFactory());
            //Mvx.IoCProvider.RegisterSingleton<IExternalStorageService>(new ExternalStorageService());
            base.InitializeFirstChance();
        }

    }
}