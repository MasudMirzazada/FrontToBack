using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboASP.DAL;
using TurboASP.Models;

namespace TurboASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly TurboASPDbContext _context;
        public HomeController(TurboASPDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Brand> brands = _context.Brands.ToList();
            return View(brands);
        }
        public  IActionResult Model(int?id)
        {
            if (id == null) return BadRequest();
            List<Model> models = _context.Models.Where(p => p.BrandId == id).ToList();
            return View(models);
        }
    }
}
