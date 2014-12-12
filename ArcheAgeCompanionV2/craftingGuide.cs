using System;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace ArcheAgeCompanionV2
{
	public class craftingGuide : ContentPage
	{


		public craftingGuide ()
		{
			Label header = new Label {
				Text = "Crafting Guide",
				Font = Font.SystemFontOfSize (20),
				HorizontalOptions = LayoutOptions.Center
			};




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

					Content = new StackLayout {

						Children = {
							new Label {
								Text = "Crafting in ArcheAge is a simple process. In order to craft an item, it is necessary to gather the necessary materials to make the item. Once all of the materials have been gathered it is possible to craft the item. For crafting higher tiers of items, it is necessary to start from the bottom and craft the lowest tier item first. This is due to the fact that the lower tier items are materials required to craft the higher tier items. Once a tier 5 item(Conqueror's) has been crafted, tier 6(Illustrious) items can be crafted. Crafting in ArcheAge relies heavily on a Random Number Generator(RNG). Tier 6 and higher weapons come as a Sealed item, and when opened 4 different items can be acquired. In order to craft tier 7(Magnificent) items, you must have a specific item out of the 4 possible. This is why crafting high tier items in ArcheAge is very difficult. Tier 7 items once again give 4 different items and the same rules apply as before. Tier 8(Epherium) has 7 different possibilities of items and tier 9(Delphinad) also has 7 different items that can result when opening the sealed item. Refer to the specific pages for details on how to craft for each vocation.\n",
								TextColor = Color.White,
								BackgroundColor = Color.Gray,
							}
						}
					}
				}, 0, 1, 0, 1);

			/*grid.Children.Add (new Label {
				Text = "Other info",
				BackgroundColor = Color.Green,
				TextColor = Color.White
			}, 0, 1, 1, 2);*/


			// Accomodate iPhone status bar.
			this.Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 5);
			Content = grid;
				
				
			
		}
	}

}

