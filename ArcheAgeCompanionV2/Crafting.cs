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
				"Craftsman's Squall Longspear",
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

			string[] t1dagger = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2dagger = {
				"Apprentice's Mountain Dagger",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3dagger = {
				"Craftsman's Mountain Dagger",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4dagger = {
				"Artificer's Mountain Dagger",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5dagger = {
				"Artisan's Mountain Dagger",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6dagger = {
				"Conqueror's Mountain Dagger",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7dagger = {
				"Illustrious Mountain Dagger",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8dagger = {
				"Magnificent Mountain Dagger",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9dagger = {
				"Epherium Mountain Dagger",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1katana = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2katana = {
				"Apprentice's Sky Katana",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3katana = {
				"Craftsman's Sky Katana",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4katana = {
				"Artificer's Sky Katana",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5katana = {
				"Artisan's Sky Katana",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6katana = {
				"Conqueror's Sky Katana",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7katana = {
				"Illustrious Sky Katana",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8katana = {
				"Magnificent Sky Katana",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9katana = {
				"Epherium Sky Katana",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1sword = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2sword = {
				"Apprentice's Summer Sword",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3sword = {
				"Craftsman's Summer Sword",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4sword = {
				"Artificer's Summer Sword",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5sword = {
				"Artisan's Summer Sword",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6sword = {
				"Conqueror's Summer Sword",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7sword = {
				"Illustrious Summer Sword",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8sword = {
				"Magnificent Summer Sword",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9sword = {
				"Epherium Summer Sword",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1club = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2club = {
				"Apprentice's Autumn Club",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3club = {
				"Craftsman's Autumn Club",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4club = {
				"Artificer's Autumn Club",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5club = {
				"Artisan's Autumn Club",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6club = {
				"Conqueror's Autumn Club",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7club = {
				"Illustrious Autumn Club",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8club = {
				"Magnificent Autumn Club",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9club = {
				"Epherium Autumn Club",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1shortspear = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2shortspear = {
				"Apprentice's Winter Shortspear",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3shortspear = {
				"Craftsman's Winter Shortspear",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4shortspear = {
				"Artificer's Winter Shortspear",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5shortspear = {
				"Artisan's Winter Shortspear",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6shortspear = {
				"Conqueror's Winter Shortspear",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7shortspear = {
				"Illustrious Winter Shortspear",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8shortspear = {
				"Magnificent Winter Shortspear",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9shortspear = {
				"Epherium Winter Shortspear",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1axe = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2axe = {
				"Apprentice's Typhoon Axe",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3axe = {
				"Craftsman's Typhoon Axe",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4axe = {
				"Artificer's Typhoon Axe",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5axe = {
				"Artisan's Typhoon Axe",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6axe = {
				"Conqueror's Typhoon Axe",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7axe = {
				"Illustrious Typhoon Axe",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8axe = {
				"Magnificent Typhoon Axe",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9axe = {
				"Epherium Typhoon Axe",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1greatsword = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2greatsword = {
				"Apprentice's Desert Greatsword",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3greatsword = {
				"Craftsman's Desert Greatsword",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4greatsword = {
				"Artificer's Desert Greatsword",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5greatsword = {
				"Artisan's Desert Greatsword",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6greatsword = {
				"Conqueror's Desert Greatsword",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7greatsword = {
				"Illustrious Desert Greatsword",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8greatsword = {
				"Magnificent Desert Greatsword",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9greatsword = {
				"Epherium Desert Greatsword",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1nodachi = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2nodachi = {
				"Apprentice's Lightning Nodachi",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3nodachi = {
				"Craftsman's Lightning Nodachi",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4nodachi = {
				"Artificer's Lightning Nodachi",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5nodachi = {
				"Artisan's Lightning Nodachi",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6nodachi = {
				"Conqueror's Lightning Nodachi",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7nodachi = {
				"Illustrious Lightning Nodachi",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8nodachi = {
				"Magnificent Lightning Nodachi",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9nodachi = {
				"Epherium Lightning Nodachi",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1greataxe = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2greataxe = {
				"Apprentice's Desert Greataxe",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3greataxe = {
				"Craftsman's Desert Greataxe",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4greataxe = {
				"Artificer's Desert Greataxe",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5greataxe = {
				"Artisan's Desert Greataxe",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6greataxe = {
				"Conqueror's Desert Greataxe",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7greataxe = {
				"Illustrious Desert Greataxe",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8greataxe = {
				"Magnificent Desert Greataxe",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9greataxe = {
				"Epherium Desert Greataxe",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1greatclub = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2greatclub = {
				"Apprentice's Sunset Greatclub",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3greatclub = {
				"Craftsman's Sunset Greatclub",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4greatclub = {
				"Artificer's Sunset Greatclub",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5greatclub = {
				"Artisan's Sunset Greatclub",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6greatclub = {
				"Conqueror's Sunset Greatclub",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7greatclub = {
				"Illustrious Sunset Greatclub",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8greatclub = {
				"Magnificent Sunset Greatclub",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9greatclub = {
				"Epherium Sunset Greatclub",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1longspear = {
				"5 Sunlight Archeum Dust",
				"5 Iron Ingot",
				"3 Blue Salt Wedge"
			};

			string[] t2longspear = {
				"Apprentice's Squall Longspear",
				"7 Sunlight Archeum Dust",
				"10 Iron Ingot",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3longspear = {
				"Craftsman's Squall Longspear",
				"5 Sunlight Archeum Shard",
				"15 Iron Ingot",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4longspear = {
				"Artificer's Squall Longspear",
				"7 Sunlight Archeum Shard",
				"20 Iron Ingot",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5longspear = {
				"Artisan's Squall Longspear",
				"5 Sunlight Archeum Crystal",
				"25 Iron Ingot",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6longspear = {
				"Conqueror's Squall Longspear",
				"7 Sunlight Archeum Crystal",
				"6 Sturdy Ingot",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7longspear = {
				"Illustrious Squall Longspear",
				"3 Sunlight Archeum Essence",
				"7 Sturdy Ingot",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8longspear = {
				"Magnificent Squall Longspear",
				"5 Sunlight Archeum Essence",
				"8 Sturdy Ingot",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9longspear = {
				"Epherium Squall Longspear",
				"7 Sunlight Archeum Essence",
				"2 Sunridge Ingot",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1shield = {
				"5 Sunlight Archeum Dust",
				"5 Lumber",
				"3 Blue Salt Wedge"
			};

			string[] t2shield = {
				"Apprentice's Quake Shield",
				"7 Sunlight Archeum Dust",
				"10 Lumber",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3shield = {
				"Craftsman's Quake Shield",
				"5 Sunlight Archeum Shard",
				"15 Lumber",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4shield = {
				"Artificer's Quake Shield",
				"7 Sunlight Archeum Shard",
				"20 Lumber",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5shield = {
				"Artisan's Quake Shield",
				"5 Sunlight Archeum Crystal",
				"25 Lumber",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6shield = {
				"Conqueror's Quake Shield",
				"7 Sunlight Archeum Crystal",
				"6 Fine Lumber",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7shield = {
				"Illustrious Quake Shield",
				"3 Sunlight Archeum Essence",
				"7 Fine Lumber",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8shield = {
				"Magnificent Quake Shield",
				"5 Sunlight Archeum Essence",
				"8 Fine Lumber",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9shield = {
				"Epherium Quake Shield",
				"7 Sunlight Archeum Essence",
				"2 Nuri Forest Lumber",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1scepter = {
				"5 Sunlight Archeum Dust",
				"5 Lumber",
				"3 Blue Salt Wedge"
			};

			string[] t2scepter = {
				"Apprentice's Meadow Scepter",
				"7 Sunlight Archeum Dust",
				"10 Lumber",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3scepter = {
				"Craftsman's Meadow Scepter",
				"5 Sunlight Archeum Shard",
				"15 Lumber",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4scepter = {
				"Artificer's Meadow Scepter",
				"7 Sunlight Archeum Shard",
				"20 Lumber",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5scepter = {
				"Artisan's Meadow Scepter",
				"5 Sunlight Archeum Crystal",
				"25 Lumber",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6scepter = {
				"Conqueror's Meadow Scepter",
				"7 Sunlight Archeum Crystal",
				"6 Fine Lumber",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"4 Gilda Dust"
			};

			string[] t7scepter = {
				"Illustrious Meadow Scepter",
				"3 Sunlight Archeum Essence",
				"7 Fine Lumber",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t8scepter = {
				"Magnificent Meadow Scepter",
				"5 Sunlight Archeum Essence",
				"8 Fine Lumber",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"9 Gilda Dust"
			};

			string[] t9scepter = {
				"Epherium Meadow Scepter",
				"7 Sunlight Archeum Essence",
				"2 Nuri Forest Lumber",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"13 Gilda Dust"
			};

			string[] t1staff = {
				"5 Sunlight Archeum Dust",
				"5 Lumber",
				"3 Blue Salt Wedge"
			};

			string[] t2staff = {
				"Apprentice's Ocean Staff",
				"7 Sunlight Archeum Dust",
				"10 Lumber",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3staff = {
				"Craftsman's Ocean Staff",
				"5 Sunlight Archeum Shard",
				"15 Lumber",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4staff = {
				"Artificer's Ocean Staff",
				"7 Sunlight Archeum Shard",
				"20 Lumber",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5staff = {
				"Artisan's Ocean Staff",
				"5 Sunlight Archeum Crystal",
				"25 Lumber",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6staff = {
				"Conqueror's Ocean Staff",
				"7 Sunlight Archeum Crystal",
				"6 Fine Lumber",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7staff = {
				"Illustrious Ocean Staff",
				"3 Sunlight Archeum Essence",
				"7 Fine Lumber",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8staff = {
				"Magnificent Ocean Staff",
				"5 Sunlight Archeum Essence",
				"8 Fine Lumber",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9staff = {
				"Epherium Ocean Staff",
				"7 Sunlight Archeum Essence",
				"2 Nuri Forest Lumber",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
			};

			string[] t1bow = {
				"5 Sunlight Archeum Dust",
				"5 Lumber",
				"3 Blue Salt Wedge"
			};

			string[] t2bow = {
				"Apprentice's Volcano Bow",
				"7 Sunlight Archeum Dust",
				"10 Lumber",
				"5 Blue Salt Wedge",
				"2 Copper Ingot"
			};

			string[] t3bow = {
				"Craftsman's Volcano Bow",
				"5 Sunlight Archeum Shard",
				"15 Lumber",
				"7 Blue Salt Wedge",
				"4 Copper Ingot"
			};

			string[] t4bow = {
				"Artificer's Volcano Bow",
				"7 Sunlight Archeum Shard",
				"20 Lumber",
				"2 Blue Salt Gloves",
				"3 Silver Ingot"
			};

			string[] t5bow = {
				"Artisan's Volcano Bow",
				"5 Sunlight Archeum Crystal",
				"25 Lumber",
				"4 Blue Salt Gloves",
				"4 Silver Ingot"
			};

			string[] t6bow = {
				"Conqueror's Volcano Bow",
				"7 Sunlight Archeum Crystal",
				"6 Fine Lumber",
				"6 Blue Salt Gloves",
				"3 Gold Ingot",
				"6 Gilda Dust"
			};

			string[] t7bow = {
				"Illustrious Volcano Bow",
				"3 Sunlight Archeum Essence",
				"7 Fine Lumber",
				"8 Blue Salt Gloves",
				"4 Gold Ingot",
				"9 Gilda Dust"
			};

			string[] t8bow = {
				"Magnificent Volcano Bow",
				"5 Sunlight Archeum Essence",
				"8 Fine Lumber",
				"3 Blue Salt Hammer",
				"3 Archeum Ingot",
				"14 Gilda Dust"
			};

			string[] t9bow = {
				"Epherium Volcano Bow",
				"7 Sunlight Archeum Essence",
				"2 Nuri Forest Lumber",
				"5 Blue Salt Hammer",
				"4 Archeum Ingot",
				"20 Gilda Dust"
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

				if (args.SelectedItem.Equals ("Apprentice's Mountain Dagger")){
					listView.ItemsSource = t1dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Mountain Dagger")){
					listView.ItemsSource = t2dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Mountain Dagger")){
					listView.ItemsSource = t3dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Mountain Dagger")){
					listView.ItemsSource = t4dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Mountain Dagger")){
					listView.ItemsSource = t5dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Dagger")){
					listView.ItemsSource = t6dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Dagger")){
					listView.ItemsSource = t7dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Dagger")){
					listView.ItemsSource = t8dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Dagger")){
					listView.ItemsSource = t9dagger;
					previousSource = dagger;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Summer Sword")){
					listView.ItemsSource = t1sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Summer Sword")){
					listView.ItemsSource = t2sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Summer Sword")){
					listView.ItemsSource = t3sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Summer Sword")){
					listView.ItemsSource = t4sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Summer Sword")){
					listView.ItemsSource = t5sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Sword")){
					listView.ItemsSource = t6sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Sword")){
					listView.ItemsSource = t7sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Sword")){
					listView.ItemsSource = t8sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Sword")){
					listView.ItemsSource = t9sword;
					previousSource = sword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Sky Katana")){
					listView.ItemsSource = t1katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Sky Katana")){
					listView.ItemsSource = t2katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Sky Katana")){
					listView.ItemsSource = t3katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Sky Katana")){
					listView.ItemsSource = t4katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Sky Katana")){
					listView.ItemsSource = t5katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Katana")){
					listView.ItemsSource = t6katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Katana")){
					listView.ItemsSource = t7katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Katana")){
					listView.ItemsSource = t8katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Katana")){
					listView.ItemsSource = t9katana;
					previousSource = katana;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Typhoon Axe")){
					listView.ItemsSource = t1axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Typhoon Axe")){
					listView.ItemsSource = t2axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Typhoon Axe")){
					listView.ItemsSource = t3axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Typhoon Axe")){
					listView.ItemsSource = t4axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Typhoon Axe")){
					listView.ItemsSource = t5axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Axe")){
					listView.ItemsSource = t6axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Axe")){
					listView.ItemsSource = t7axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Axe")){
					listView.ItemsSource = t8axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Axe")){
					listView.ItemsSource = t9axe;
					previousSource = axe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Autumn Club")){
					listView.ItemsSource = t1club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Autumn Club")){
					listView.ItemsSource = t2club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Autumn Club")){
					listView.ItemsSource = t3club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Autumn Club")){
					listView.ItemsSource = t4club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Autumn Club")){
					listView.ItemsSource = t5club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Club")){
					listView.ItemsSource = t6club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Club")){
					listView.ItemsSource = t7club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Club")){
					listView.ItemsSource = t8club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Club")){
					listView.ItemsSource = t9club;
					previousSource = club;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Winter Shortspear")){
					listView.ItemsSource = t1shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Winter Shortspear")){
					listView.ItemsSource = t2shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Winter Shortspear")){
					listView.ItemsSource = t3shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Winter Shortspear")){
					listView.ItemsSource = t4shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Winter Shortspear")){
					listView.ItemsSource = t5shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Shortspear")){
					listView.ItemsSource = t6shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Shortspear")){
					listView.ItemsSource = t7shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Shortspear")){
					listView.ItemsSource = t8shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Shortspear")){
					listView.ItemsSource = t9shortspear;
					previousSource = shortspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Desert Greatsword")){
					listView.ItemsSource = t1greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Desert Greatsword")){
					listView.ItemsSource = t2greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Desert Greatsword")){
					listView.ItemsSource = t3greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Desert Greatsword")){
					listView.ItemsSource = t4greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Desert Greatsword")){
					listView.ItemsSource = t5greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Greatsword")){
					listView.ItemsSource = t6greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Greatsword")){
					listView.ItemsSource = t7greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Greatsword")){
					listView.ItemsSource = t8greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Greatsword")){
					listView.ItemsSource = t9greatsword;
					previousSource = greatsword;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Lightning Nodachi")){
					listView.ItemsSource = t1nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Lightning Nodachi")){
					listView.ItemsSource = t2nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Lightning Nodachi")){
					listView.ItemsSource = t3nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Lightning Nodachi")){
					listView.ItemsSource = t4nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Lightning Nodachi")){
					listView.ItemsSource = t5nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustious Nodachi")){
					listView.ItemsSource = t6nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Nodachi")){
					listView.ItemsSource = t7nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Nodachi")){
					listView.ItemsSource = t8nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Nodachi")){
					listView.ItemsSource = t9nodachi;
					previousSource = nodachi;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Desert Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Desert Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Desert Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Desert Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Desert Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Greataxe")){
					listView.ItemsSource = t1greataxe;
					previousSource = greataxe;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Sunset Greatclub")){
					listView.ItemsSource = t1greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Sunset Greatclub")){
					listView.ItemsSource = t2greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Sunset Greatclub")){
					listView.ItemsSource = t3greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Sunset Greatclub")){
					listView.ItemsSource = t4greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Sunset Greatclub")){
					listView.ItemsSource = t5greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Greatclub")){
					listView.ItemsSource = t6greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Greatclub")){
					listView.ItemsSource = t7greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Greatclub")){
					listView.ItemsSource = t8greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Greatclub")){
					listView.ItemsSource = t9greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Greatclub")){
					listView.ItemsSource = t9greatclub;
					previousSource = greatclub;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Squall Longspear")){
					listView.ItemsSource = t1longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Squall Longspear")){
					listView.ItemsSource = t2longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Squall Longspear")){
					listView.ItemsSource = t3longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Squall Longspear")){
					listView.ItemsSource = t4longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Squall Longspear")){
					listView.ItemsSource = t5longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Longspear")){
					listView.ItemsSource = t6longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Longspear")){
					listView.ItemsSource = t7longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Longspear")){
					listView.ItemsSource = t8longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Shortspear")){
					listView.ItemsSource = t9longspear;
					previousSource = longspear;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Quake Shield")){
					listView.ItemsSource = t1shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Quake Shield")){
					listView.ItemsSource = t2shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Quake Shield")){
					listView.ItemsSource = t3shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Quake Shield")){
					listView.ItemsSource = t4shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Quake Shield")){
					listView.ItemsSource = t5shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Shield")){
					listView.ItemsSource = t6shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Shield")){
					listView.ItemsSource = t7shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Shield")){
					listView.ItemsSource = t8shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Shield")){
					listView.ItemsSource = t9shield;
					previousSource = shield;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Meadow Scepter")){
					listView.ItemsSource = t1scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Meadow Scepter")){
					listView.ItemsSource = t2scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Meadow Scepter")){
					listView.ItemsSource = t3scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Meadow Scepter")){
					listView.ItemsSource = t4scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Meadow Scepter")){
					listView.ItemsSource = t5scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Scepter")){
					listView.ItemsSource = t6scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Scepter")){
					listView.ItemsSource = t7scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Scepter")){
					listView.ItemsSource = t8scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Scepter")){
					listView.ItemsSource = t9scepter;
					previousSource = scepter;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Ocean Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Ocean Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Ocean Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Ocean Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Ocean Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Staff")){
					listView.ItemsSource = t1staff;
					previousSource = staff;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Apprentice's Volcano Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Craftsman's Volcano Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artificer's Volcano Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Artisan's Volcano Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Conqueror's Volcano Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Illustrious Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Magnificent Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Epherium Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
					pageLayout.Children.Add(backButton);
				}

				if (args.SelectedItem.Equals ("Sealed Delphinad Bow")){
					listView.ItemsSource = t1bow;
					previousSource = bow;
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