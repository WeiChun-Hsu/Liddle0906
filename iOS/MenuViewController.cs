using System;
using System.Linq;
using System.Collections.Generic;

using UIKit;


using Debug = System.Diagnostics.Debug;


namespace Liddle.iOS
{
	public partial class MenuViewController : UIViewController
	{
		private PlayStation SelectedPlayStation { get; set; }

		public MenuViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			// moveToDetailViewSegue
			ShowTable ();
		
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public void ShowTable ()
		{

			var list = new List<PlayStation> ();
			// 25.1362681,121.5063063
			list.Add (new PlayStation { Name = @"新北投公園", Location = new GeoLocation { Lat = 25.1362681, Lng = 121.5063063 } });


			var tableSource = new PlayStationTableSource (list);
			featuresTable.Source = tableSource;

			tableSource.PlayStationSelected += (sender, e) => { 
				Debug.WriteLine (e.SelectedPlayStation.Name);
				SelectedPlayStation = e.SelectedPlayStation;

				PerformSegue ("moveToDetailViewSegue", this);

			};


			featuresTable.ReloadData ();


		}

		public override void PrepareForSegue (UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if ("moveToDetailViewSegue" == segue.Identifier) {
				if (segue.DestinationViewController is DetailViewController) {
					var dest = segue.DestinationViewController as DetailViewController;
					dest.SelectedPlayStation = SelectedPlayStation;
				}
			
			
			}

		}

		public class PlayStationTableSource : UITableViewSource
		{
			// CellView Identifier
			const string PlayStationViewCellIdentifier = @"PlayStationViewCell";

			// ctor. Model

			private List<PlayStation> PlayStations { get; set; }

			public PlayStationTableSource (IEnumerable<PlayStation> stations)
			{
				PlayStations = new List<PlayStation> ();
				PlayStations.AddRange (stations);
			}

			// Model -> Controller -> View

			// Memory
			public override nint RowsInSection (UITableView tableview, nint section)
			{
				return (nint)PlayStations.Count;
			}

			// Controller -> View
			public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				PlayStationViewCell cell = tableView.DequeueReusableCell (PlayStationViewCellIdentifier) as PlayStationViewCell;

				PlayStation station = PlayStations [indexPath.Row];

				cell.UpdateUI (station);

				return cell;


			}


			// View -> Controller

			public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
			{
				tableView.DeselectRow (indexPath, true);

				PlayStation station = PlayStations [indexPath.Row];

				EventHandler<PlayStationSelectedEventArgs> handle = PlayStationSelected;

				if (null != handle) {

					var args = new PlayStationSelectedEventArgs { SelectedPlayStation = station };

					handle (this, args);
				}

			}

			public event EventHandler<PlayStationSelectedEventArgs> PlayStationSelected;

		}

		public class PlayStationSelectedEventArgs : EventArgs
		{

			public PlayStation SelectedPlayStation { get; set; }

		}
	}
}


