using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Models;

namespace BatheneyPieShop.Model
{
	public interface IPieRepository
	{
		IEnumerable<Pie> AllPies { get; }
		IEnumerable<Pie> PieOfTheWeek { get; }
		Pie GetPieById(int PieId);
	}
}
