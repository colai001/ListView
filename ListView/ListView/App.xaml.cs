using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;



using Xamarin.Forms;

namespace ListView
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new ListView.MainPage();
		}

		protected override void OnStart ()
		{
		    AppCenter.Start("android=a691b556-af6a-4389-9923-a65f9cb6deca;" +
		                    "uwp={Your UWP App secret here};" +
		                    "ios={Your iOS App secret here}",
		        typeof(Analytics), typeof(Crashes));

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
