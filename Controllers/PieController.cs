using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatheneyPieShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace BatheneyPieShop.Controllers
{
    public class PieController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            return View(_pieRepository.AllPies);
        }
    }
}
