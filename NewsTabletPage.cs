using System;

using Xamarin.Forms;

namespace Library
{
	public class NewsTabletPage : MasterDetailPage
	{
		public NewsTabletPage()
		{
			Title = "News";
			Master = new NewsPhonePage();
			Detail = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					Children =
					{
						new Label { Text = "Select a News", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
					}
				}
			};
			((NewsPhonePage)Master).ItemSelected = (news) =>
			{
				Detail = new WebViewPage(news.url);
				if (Device.OS != TargetPlatform.Windows)
					IsPresented = false;
			};

			IsPresented = true;

		}
		protected override bool OnBackButtonPressed()
		{
			if (IsPresented)
			{
				return base.OnBackButtonPressed();
			}
			else
			{
				IsPresented = true;
				return true;
			}
		}

	}
}

