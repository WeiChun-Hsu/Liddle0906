using System;
using System.Threading.Tasks;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using static System.Diagnostics.Debug;

namespace Liddle.Droid
{
	[Activity (Label = "Liddle", MainLauncher = true)]
	public class SplashActivity : Activity
	{
		//ImageView iconImageView;
		private WebWorker Worker { get; set; }

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView (Resource.Layout.splashview);

			//iconImageView = FindViewById<ImageView> (Resource.Id.splashview_imageView);
		
			Worker = new WebWorker ();

			Worker.HtmlStringReceived += (sender, e) => {

				WriteLine ($"length:{ e.Html.Length }");

				RunOnUiThread (() => {

					StartActivity ( typeof(MainActivity) );


				});
			};

			Task.Run (() => {
				RunWeb ();
			});
		
		}

		private async void RunWeb ()
		{
			var task = Worker.DownloadHtmlString ("https://google.com");
			await task;
		}
	}
}

