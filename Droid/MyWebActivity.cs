
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

using Android.Webkit;

namespace Liddle.Droid
{
	[Activity (Label = "MyWebActivity")]
	public class MyWebActivity : Activity
	{

		WebView myWebView;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
			SetContentView (Resource.Layout.mywebview);

			myWebView = FindViewById<WebView> (Resource.Id.mywebview_webview);

			myWebView.LoadUrl ("https://stackoverflow.com");
		}
	}
}

