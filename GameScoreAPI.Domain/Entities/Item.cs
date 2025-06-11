using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Effect { get; set; } = string.Empty;

		public ICollection<PlayerItemInMatch> ItemsInMatches { get; set; } = new List<PlayerItemInMatch>();
	}

}
