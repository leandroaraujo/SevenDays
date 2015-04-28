﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SevenDays.Tests.UI
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if(platform == Platform.Android) {
				return ConfigureApp
					.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
					.ApkFile ("../../../../SevenDays.UI/SevenDays.UI.Droid/bin/Debug/SevenDays.UI.Droid.apk")
					.StartApp();
			}

			return ConfigureApp
				.iOS
			// TODO: Update this path to point to your iOS app and uncomment the
			// code if the app is not included in the solution.
				.AppBundle ("../../../../SevenDays.UI/SevenDays.UI.iOS/bin/iPhoneSimulator/Debug/SevenDaysUIiOS.app")
				.StartApp();
		}
	}
}

