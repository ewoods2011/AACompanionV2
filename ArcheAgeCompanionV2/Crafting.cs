using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ArcheAgeCompanionV2
{
	public class Crafting : ContentPage

	{
		private static StackLayout pageLayout;
		private static String[] previousSource;
		private static List<String> weaponsList = new List<String> ();

		public Crafting ()
		{

			string[] crafts = {
				"Crafting Guide",
				"Carpentry",
				"Weaponry"
			};

			string[] weaponry = {
				"Daggers",
				"Swords",
				"Katanas",
				"Axes",
				"Clubs",
				"Shortspears",
				"Greatswords",
				"Nodachis",
				"Greataxes",
				"Greatclubs",
				"Longspears",
				"Shields"
			};

			string[] carpentry = {
				"Scepters",
				"Staves",
				"Bows"
			};

			string[] dagger = {
				"Apprentice's Mountain Dagger",
				"Craftsman's Mountain Dagger",
				"Artificer's Mountain Dagger",
				"Artisan's Mountain Dagger",
				"Conqueror's Mountain Dagger",
				"Sealed Illustrious Dagger",
				"Sealed Magnificent Dagger",
				"Sealed Epherium Dagger",
			 	"Sealed Delphinad Dagger"
			};

			string[] sword = {
				"Apprentice's Summer Sword",
				"Craftsman's Summer Sword",
				"Artificer's Summer Sword",
				"Artisan's Summer Sword",
				"Conqueror's Summer Sword",
				"Sealed Illustrious Sword",
				"Sealed Magnificent Sword",
				"Sealed Epherium Sword",
				"Sealed Delphinad Sword"
			};

			string[] katana = {
				"Apprentice's Sky Katana",
				"Craftsman's Sky Katana",
				"Artificer's Sky Katana",
				"Artisan's Sky Katana",
				"Conqueror's Sky Katana",
				"Sealed Illustrious Katana",
				"Sealed Magnificent Katana",
				"Sealed Epherium Katana", 
				"Sealed Delphinad Katana"
			};

			string[] axe = {
				"Apprentice's Typhoon Axe",
				"Craftsman's Typhoon Axe",
				"Artificer's Typhoon Axe",
				"Artisan's Typhoon Axe",
				"Conqueror's Typhoon Axe",
				"Sealed Illustrious Axe", 
				"Sealed Magnificent Axe",
				"Sealed Epherium Axe",
				"Sealed Delphinad Axe"
			};

			string[] club = {
				"Apprentice's Autumn Club",
				"Craftsman's Autumn Club",
				"Artificer's Autumn Club",
				"Artisan's Autumn Club",
				"Conqueror's Autumn Club",
				"Sealed Illustrious Club",
				"Sealed Magnificent Club",
				"Sealed Epherium Club",
				"Sealed Delphinad Club"
			};

			string[] shortspear = {
				"Apprentice's Winter Shortspear", 
				"Craftsman's Winter Shortspear",
				"Artificer's Winter Shortspear",
				"Artisan's Winter Shortspear",
				"Conqueror's Winter Shortspear" ,
				"Sealed Illustrious Shortspear",
				"Sealed Magnificent Shortspear",
				"Sealed Epherium Shortspear",
				"Sealed Delphinad Shortspear"
			};

			string[] greatsword = {
				"Apprentice's Desert Greatsword",
				"Craftsman's Desert Greatsword",
				"Artificer' Desert Greatsword",
				"Artisan's Desert Greatsword",
				"Conqueror's Desert Greatsword",
				"Sealed Illustrious Greatsword",
				"Sealed Magnificent Greatsword",
				"Sealed Epherium Greatsword",
				"Sealed Delphinad Greatsword"
			};

			string[] nodachi = {
				"Apprentice's Lightning Nodachi",
				"Craftsman's Lightning Nodachi",
				"Artificer's Lightning Nodachi",
				"Artisan's Lightning Nodachi",
				"Conqueror's Lightning Nodachi",
				"Sealed Illustious Nodachi",
				"Sealed Magnificent Nodachi",
				"Sealed Epherium Nodachi",
				"Sealed Delphinad Nodachi"
			};

			string[] greataxe = {
				"Apprentice's Desert Greataxe",
				"Craftsman's Desert Greataxe",
				"Artificer's Desert Greataxe",
				"Artisan's Desert Greataxe",
				"Conqueror's Desert Greataxe",
				"Sealed Illustrious Greataxe",
				"Sealed Magnificent Greataxe",
				"Sealed Epherium Greataxe",
				"Sealed Delphinad Greataxe"
			};

			string[] greatclub = {
				"Apprentice's Sunset Greatclub",
				"Craftsman's Sunset Greatclub",
				"Artificer's Sunset Greatclub",
				"Artisan's Sunset Greatclub",
				"Conqueror's Sunset Greatclub",
				"Sealed Illustrious Greatclub",
				"Sealed Magnificent Greatclub",
				"Sealed Epherium Greatclub",
				"Sealed Delphinad Greatclub"
			};

			string[] longspear = {
				"Apprentice's Squall Longspear",
				"Craftman's Squall Longspear",
				"Artificer's Squall Longspear",
				"Artisan's Squall Longspear",
				"Conqueror's Squall Longspear",
				"Sealed Illustrious Longspear",
				"Sealed Magnificent Longspear",
				"Sealed Epherium Longspear",
				"Sealed Delphinad Shortspear"
			};

			string[] shield = {
				"Apprentice's Quake Shield",
				"Craftsman's Quake Shield",
				"Artificer's Quake Shield",
				"Artisan's Quake Shield",
				"Conqueror's Quake Shield",
				"Sealed Illustrious Shield",
				"Sealed Magnificent Shield",
				"Sealed Epherium Shield",
				"Sealed Delphinad Shield"
			};

			string[] scepter = {
				"Apprentice's Meadow Scepter",
				"Craftsman's Meadow Scepter",
				"Artificer's Meadow Scepter",
				"Artisan's Meadow Scepter",
				"Conqueror's Meadow Scepter",
				"Sealed Illustrious Scepter",
				"Sealed Magnificent Scepter",
				"Sealed Epherium Scepter",
				"Sealed Delphinad Scepter"
			};

			string[] staff = {
				"Apprentice's Ocean Staff",
				"Craftsman's Ocean Staff",
				"Artificer's Ocean Staff",
				"Artisan's Ocean Staff",
				"Conqueror's Ocean Staff",
				"Sealed Illustrious Staff",
				"Sealed Magnificent Staff",
				"Sealed Epherium Staff",
				"Sealed Delphinad Staff"
			};

			string[] bow = {
				"Apprentice's Volcano Bow",
				"Craftsman's Volcano Bow",
				"Artificer's Volcano Bow",
				"Artisan's Volcano Bow",
				"Conqueror's Volcano Bow",
				"Sealed Illustrious Bow",
				"Sealed Magnificent Bow",
				"Sealed Epherium Bow",
				"Sealed Delphinad Bow"
			};

			ListView listView = new ListView {
				ItemsSource = crafts,
			};


			Button backButton = new Button
			{
				Text = " Back ",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1

			};



			backButton.Clicked += delegate(object sender, EventArgs e) {
				listView.ItemsSource = previousSource;
				pageLayout.Children.Remove(backButton);
				listView.SelectedItem = "";
			};


			listView.ItemSelected += async (sender, args) => {

				// This is where you would put your “go to one of the selected pages” 
				if (args.SelectedItem.Equals ("Crafting Guide")){

					var todoPage = new craftingGuide(); // so the new page shows correct data
					await Navigation.PushAsync(todoPage);

				}

				if (args.SelectedItem.Equals ("Weaponry")){
					listView.ItemsSource = weaponry;
					previousSource = crafts;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Carpentry")){
					listView.ItemsSource = carpentry;
					previousSource = crafts;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Daggers")){
					listView.ItemsSource = dagger;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Swords")){
					listView.ItemsSource = sword;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Katanas")){
					listView.ItemsSource = katana;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Clubs")){
					listView.ItemsSource = club;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Shortspears")){
					listView.ItemsSource = shortspear;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Axes")){
					listView.ItemsSource = axe;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Greatswords")){
					listView.ItemsSource = greatsword;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Nodachis")){
					listView.ItemsSource = nodachi;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Greataxes")){
					listView.ItemsSource = greataxe;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Greatclubs")){
					listView.ItemsSource = greatclub;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Longspears")){
					listView.ItemsSource = longspear;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Shields")){
					listView.ItemsSource = shield;
					previousSource = weaponry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Scepters")){
					listView.ItemsSource = scepter;
					previousSource = carpentry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Scepters")){
					listView.ItemsSource = scepter;
					previousSource = carpentry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Staves")){
					listView.ItemsSource = staff;
					previousSource = carpentry;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Bows")){
					listView.ItemsSource = bow;
					previousSource = carpentry;
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