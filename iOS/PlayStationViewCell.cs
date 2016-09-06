using System;

using Foundation;
using UIKit;

namespace Liddle.iOS
{
	public partial class PlayStationViewCell : UITableViewCell
	{
		protected PlayStationViewCell (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public void UpdateUI (PlayStation station) {
			lbName.Text = station.Name;
		}

	}
}
