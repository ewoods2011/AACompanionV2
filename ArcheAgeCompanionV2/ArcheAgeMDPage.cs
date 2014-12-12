using System;
using Xamarin.Forms;

namespace ArcheAgeCompanionV2
{
	public class ArcheAgeMDPage : MasterDetailPage
	{
		public ArcheAgeMDPage ()
		{

			string[] myPageNames = {
				"Menu",
				"Weapons",
				"Crafting"
			};
				

			// Create ListView for the Master page.
			ListView listView = new ListView {
				ItemsSource = myPageNames,
			};

			// The Master page is actually the Menu page for us
			this.Master = new ContentPage {
				Title = "ArcheAge Companion",
				Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null,
				BackgroundColor = Color.Black,
				Content = new StackLayout {
					Children = { 
						listView
					},
				}
			};
					

			listView.ItemSelected += (sender, args) => {
				// Set the BindingContext of the detail page.
				this.Detail.BindingContext = args.SelectedItem;

				// This is where you would put your “go to one of the selected pages” 
				if(args.SelectedItem.Equals("Menu")){
					this.Detail = new NavigationPage (
						new mainPage{Title = "ArcheAge Companion"}
					);
				}
				else if(args.SelectedItem.Equals("Weapons")){
					this.Detail = new NavigationPage (
						new weaponSelect{Title = "Weapon Selection" }
					);
				}
				else if(args.SelectedItem.Equals("Crafting")){
					this.Detail = new NavigationPage (
						new Crafting{Title = "Crafting" }
					);
				}
				else{
					this.Detail = new NavigationPage (
						new ContentPage{Title = "ArcheAge Companion"}
					);
				}

				// Show the detail page.
				this.IsPresented = false;
			};


			this.Detail = new NavigationPage (
				new mainPage{Title = "ArcheAge Companion"}

			);

		}

	}
}



