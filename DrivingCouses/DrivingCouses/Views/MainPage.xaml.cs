using DrivingCouses.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DrivingCourses.Core.ViewModels.PageViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrivingCouses.Views
{
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Root, NoHistory = true, WrapInNavigationPage = false)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();     
        }
    
    }
}