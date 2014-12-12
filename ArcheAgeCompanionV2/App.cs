using System;
using Xamarin.Forms;

namespace ArcheAgeCompanionV2
{
	public class App
	{
		public static Page getMainPage(){
			database = new AAWeaponDatabase();
			return new ArcheAgeMDPage();

		}

		static AAWeaponDatabase database;
		public static AAWeaponDatabase Database {
			get { return database; }
		}


	}
}

