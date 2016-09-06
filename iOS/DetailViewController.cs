using System;

using UIKit;

namespace Liddle.iOS
{
	public partial class DetailViewController : UIViewController
	{
		public PlayStation SelectedPlayStation { get; set; }

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			// moveToMapViewSegue
			// moveToWebViewSegue
			btnMap.TouchUpInside += (sender, e) => {
				PerformSegue ("moveToMapViewSegue", this);
			};


		}

		public override void PrepareForSegue (UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if ("moveToMapViewSegue" == segue.Identifier) { 
				if (segue.DestinationViewController is MyMapViewController) {
					var dest = segue.DestinationViewController as MyMapViewController;
					dest.SelectedPlayStation = SelectedPlayStation;
				}


			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


