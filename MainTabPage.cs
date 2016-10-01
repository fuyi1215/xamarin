using System;

using Xamarin.Forms;

namespace Library
{
	class MainTabPage : TabbedPage
	{
		public MainTabPage()
		{
			this.Title = "TabbedPage";

			//BarTextColor = Color.Black;


			if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
			{
				this.Children.Add(new NavigationPage(new NewsTabletPage())
				{
					Title = "News",

					BarTextColor = Color.Black,
					BackgroundColor = Color.FromHex("63ad72")

				}
			);
			}
			else
				this.Children.Add(new NavigationPage(new NewsPhonePage())
				{
					Title = "News",

					BarTextColor = Color.Black,
					BackgroundColor = Color.FromHex("63ad72")

				}
			);


			this.Children.Add(new ContentPage
			{
				Title = "Calendar",

				Content = new StackLayout
				{
					Children = {
					new BoxView { Color = Color.Blue },
					new BoxView { Color = Color.Red}
					}
				}

			});

			this.Children.Add(new NavigationPage(new CatalogPage())
			{
				Title = "CatalogPage",

				BarTextColor = Color.Black,
				BackgroundColor = Color.FromHex("63ad72")

			});
			this.Children.Add(new ContentPage
			{
				Title = "More",
				Content = new StackLayout
				{
					Children = {
					new BoxView { Color = Color.Blue },
					new BoxView { Color = Color.Red}
					}
				}

			});
		}
		
	}
}



