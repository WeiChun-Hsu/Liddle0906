
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Liddle.Droid
{
	[Activity (Label = "DetailActivity")]
	public class DetailActivity : Activity
	{
		TextView lbDescription;
		Button btnWeb;
		Button btnMap;

		public override void SendBroadcastAsUser (Intent intent, UserHandle user)
		{
			base.SendBroadcastAsUser (intent, user);
		}

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView (Resource.Layout.detailview);

			lbDescription = FindViewById<TextView> (Resource.Id.detailview_lbDescription);
			btnWeb = FindViewById<Button> (Resource.Id.detailview_btnWeb);
			btnMap = FindViewById<Button> (Resource.Id.detailview_btnMap);
		}
	}
}

