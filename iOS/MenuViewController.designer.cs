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
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UIImageView descriptionImageView { get; set; }

		[Outlet]
		UIKit.UITableView featuresTable { get; set; }

		[Outlet]
		UIKit.UILabel lbDescription { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (descriptionImageView != null) {
				descriptionImageView.Dispose ();
				descriptionImageView = null;
			}

			if (lbDescription != null) {
				lbDescription.Dispose ();
				lbDescription = null;
			}

			if (featuresTable != null) {
				featuresTable.Dispose ();
				featuresTable = null;
			}
		}
	}
}
