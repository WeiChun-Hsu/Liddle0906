// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Liddle.iOS
{
	[Register ("MyMapViewController")]
	partial class MyMapViewController
	{
		[Outlet]
		MapKit.MKMapView myMapView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myMapView != null) {
				myMapView.Dispose ();
				myMapView = null;
			}
		}
	}
}
