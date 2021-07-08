using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Model;

namespace BatheneyPieShop.Models
{
	public class Pie
	{
		public int PieId { get; set; }
		public string name { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string AllergyInformation { get; set; }
		public decimal price { get; set; }
		public string ImageUrl { get; set; }
		public string ImageThumbnailUrl { get; set; }
		public bool IsPie{get; set;}
		public bool InStock { get; set; }
		public Category Category { get; set; }
		public bool IsPieOfTheWeek { get; internal set; }
	}
}
