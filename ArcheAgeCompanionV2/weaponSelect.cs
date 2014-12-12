using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace ArcheAgeCompanionV2
{
	public class weaponSelect : ContentPage
	{
		private static StackLayout pageLayout;
		private static String[] previousSource;
		private static String selectedType;
		private static List<Weapon> weaponsList = new List<Weapon>();


		public weaponSelect ()
		{

			string[] weaponTypes = {
				"1H Weapon",
				"2H Weapon",
				"Instruments",
				"Bow"
			};

			string[] oneHandWeapons = {
				"Dagger",
				"Sword",
				"Katana",
				"Axe",
				"Club",
				"Scepter",
				"Shortspear"
			};

			string[] twoHandWeapons = {
				"Greatsword",
				"Nodachi",
				"Greataxe",
				"Greatclub",
				"Staff",
				"Longspear"
			};

			string[] instruments = {
				"Lute",
				"Flute",
				"Drum"
			};

			ListView listView = new ListView {
				ItemsSource = weaponTypes,
			};

			Button backButton = new Button
			{
				Text = " Back ",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1

			};
			backButton.Clicked += delegate(object sender, EventArgs e) {
				listView.ItemsSource = previousSource;
				if(previousSource.Equals(weaponTypes))
					pageLayout.Children.Remove(backButton);
				listView.SelectedItem = "";
			};
				

			listView.ItemSelected += (sender, args) => {

				// This is where you would put your “go to one of the selected pages” 
				if (args.SelectedItem.Equals ("1H Weapon")){
					listView.ItemsSource = oneHandWeapons;
					selectedType = "1HWeapon";
					previousSource = weaponTypes;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("2H Weapon")){
					listView.ItemsSource = twoHandWeapons;
					selectedType = "1HWeapon";
					previousSource = weaponTypes;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Instruments")){
					listView.ItemsSource = instruments;
					selectedType = "1HWeapon";
					previousSource = weaponTypes;
					pageLayout.Children.Add(backButton);
				}
				if (args.SelectedItem.Equals ("Dagger")){
					weaponsList = App.Database.GetSpecificItems("1HWeapon", "Dagger");
					List<String> nameSource = new List<String>();
					foreach(var w in weaponsList){
						System.Diagnostics.Debug.WriteLine("1");
						nameSource.Add(w.name);
					}
					listView.ItemsSource = nameSource.ToArray();
					previousSource = oneHandWeapons;
					pageLayout.Children.Add(backButton);
				}	

			};

			pageLayout = new StackLayout {
				Children = { 
					listView
				},
			};

			this.Content = pageLayout;

		}

						
	}
}


