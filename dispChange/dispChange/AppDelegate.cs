using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace dispChange
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		dispChangeViewController viewController;
		UIButton button;
		UILabel label;
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			button = new UIButton (UIButtonType.RoundedRect);
			button.Frame = new RectangleF (20, 20, 100, 20);
			button.SetTitle ("button", UIControlState.Normal);
			button.TouchUpInside += (object sender, EventArgs e) => {
				Console.WriteLine("push");
			};


			label = new UILabel(new RectangleF (20, 60, 100, 20));
			label.Text = "label";
			
			viewController = new dispChangeViewController ();
			viewController.Add (button);
			viewController.Add (label);
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

