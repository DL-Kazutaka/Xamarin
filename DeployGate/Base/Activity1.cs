using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Xna.Framework;

using Com.Deploygate.Sdk;

namespace Base
{
	[Activity (Label = "Base", 
		Icon = "@drawable/icon",
		Theme = "@style/Theme.Splash",
        MainLauncher = true,
		AlwaysRetainTaskState = true,
		LaunchMode = Android.Content.PM.LaunchMode.SingleInstance,
		ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation |
		Android.Content.PM.ConfigChanges.KeyboardHidden |
		Android.Content.PM.ConfigChanges.Keyboard)]
	public class Activity1 : AndroidGameActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create our OpenGL view, and display it
			Game1.Activity = this;
			var g = new Game1 ();
			SetContentView (g.Window);

            DeployGate.LogDebug("起動しました！");

			g.Run ();
		}
	}

    [Application]
    class BaseApp : Application
    {
        public BaseApp(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            DeployGate.Install(this, null, true);
        }
    }
}


