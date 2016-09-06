using System;

using UIKit;
using MapKit;
using CoreLocation;

namespace Liddle.iOS
{
	public partial class MyMapViewController : UIViewController
	{
		public PlayStation SelectedPlayStation { get; internal set; }

		public MyMapViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		
		
			var mapCenter = new CLLocationCoordinate2D (
				SelectedPlayStation.Location.Lat, SelectedPlayStation.Location.Lng);
			myMapView.CenterCoordinate = mapCenter;


			var mapRegion = MKCoordinateRegion.FromDistance (mapCenter, 4000, 4000);
			myMapView.Region = mapRegion;

			myMapView.ShowsUserLocation = true;
		
		
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


