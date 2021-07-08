using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Models;

namespace BatheneyPieShop.Model
{
	public interface IPieRepository
	{
		IEnumerable<Pie> AllPies { get; set; }
		IEnumerable<Pie> PieOfTheWeek { get; set; }
		Pie GetPieById(int PieId);
	}
}
