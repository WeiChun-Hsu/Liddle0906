

using Android.App;
using Android.Widget;
using Android.OS;

namespace Liddle.Droid
{
	[Activity (Label = "Liddle", Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		
		ImageView descriptionImageView;
		TextView lbDescription;
		ListView featuresListView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.menuview);

			descriptionImageView = FindViewById<ImageView> (Resource.Id.menuview_image);
			lbDescription = FindViewById<TextView> (Resource.Id.menuview_lbDescription);
			featuresListView = FindViewById<ListView> (Resource.Id.menuview_featuresListView);

		}


	}
}


