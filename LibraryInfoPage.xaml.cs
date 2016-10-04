using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;
using Xamarin.Forms;

namespace Library
{
	public partial class LibraryInfoPage : ContentPage
	{
		private LibInfoViewModel viewModel;
		public LibraryInfoPage(libInfo lib)
		{
			InitializeComponent();
			BindingContext = viewModel = new LibInfoViewModel(lib, this);
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			var position = new Position(viewModel.lib.Latitude,viewModel.lib.Longitude); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = viewModel.lib.Name,
				Address = viewModel.lib.StreetAddress
			};
			MyMap.Pins.Add(pin);

			MyMap.MoveToRegion(
				MapSpan.FromCenterAndRadius(
					position, Distance.FromMiles(.2)));

		}
	}

}
