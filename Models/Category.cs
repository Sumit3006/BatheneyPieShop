using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Models;

namespace BatheneyPieShop.Model
{
	public class Category
	{
		public int CategoryId{get; set;}
		public string CategoryName{get; set;}
		public string Description { get; set; }
		public List<Pie> Pies { get; set; }
	}
}
