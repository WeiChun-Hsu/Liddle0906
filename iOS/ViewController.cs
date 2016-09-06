using System;
using System.Threading.Tasks;

using UIKit;

using static System.Diagnostics.Debug;

namespace Liddle.iOS
{
	public partial class ViewController : UIViewController
	{
		private WebWorker Worker { get; set; }

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//
			Worker = new WebWorker ();

			Worker.HtmlStringReceived += (sender, e) => {

				WriteLine ( $"length:{ e.Html.Length }");

				InvokeOnMainThread (() => {
					PerformSegue ("moveToMenuViewSegue", this);
				});
			};

			Task.Run (() => {
				RunWeb ();
			});


			// 

		}

		private async void RunWeb () { 
			var task = Worker.DownloadHtmlString ("https://google.com");
			await task;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
