using System;
using SQLite;

namespace ArcheAgeCompanionV2
{
	[Table ("weaponTable")]
	public class Weapon
	{

		[PrimaryKey]
		public int ID { get; set; }
		public string type { get; set; }
		public string subType { get; set; }
		public string name { get; set; }
		public int level { get; set; }


		public Weapon ()
		{
		}
	}
}

