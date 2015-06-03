using System;

using Xamarin.Forms;

namespace qrReaderForms
{
	public class App : Application
	{
		public App ()
		{
			NavigationPage root = new NavigationPage (new MyPage ());
			MainPage = root;
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

