using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Model;
using Microsoft.EntityFrameworkCore;

namespace BatheneyPieShop.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly AppDbContext _appDbContext;
  

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PieOfTheWeek
        {
            get
            {
                return _appDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int PieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.PieId == PieId);
        }
    }
}
