using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ArcheAgeCompanionV2
{
	public class mainPage : ContentPage
	{
		public mainPage ()
		{
			Grid grid = new Grid {
				BackgroundColor = Color.Black,
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = {
					new RowDefinition { Height = new GridLength (5, GridUnitType.Star) },
					new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength (1, GridUnitType.Star) },
				}
			};

			grid.Children.Add (
				new ScrollView {
					VerticalOptions = LayoutOptions.FillAndExpand,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					Content = new StackLayout {
						VerticalOptions = LayoutOptions.FillAndExpand,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						BackgroundColor = Color.White,
						Children = {
							new Label {
								Text = "This can be some news stuff and patch notes",
								TextColor = Color.Black,
							}
						}
					}
				}, 0, 1, 0, 1);

			grid.Children.Add (new Label {
				Text = "Other info",
				BackgroundColor = Color.Green,
				TextColor = Color.White
			}, 0, 1, 1, 2);


			// Accomodate iPhone status bar.
			this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);
			Content = grid;
		}
	}
}

