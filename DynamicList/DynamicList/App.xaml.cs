using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DynamicList
{
	public partial class App : Application
	{

        public static int ScreenHeight { get; set; }
        public static int ScreenWidth { get; set; }
        public App ()
		{
			InitializeComponent();

			MainPage = new DynamicList.MainPage();

		}

 
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
