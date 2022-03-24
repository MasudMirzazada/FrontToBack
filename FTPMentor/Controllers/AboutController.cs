using FTPMentor.DAL;
using FTPMentor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTPMentor.Controllers
{
    public class AboutController : Controller
    {
        private readonly MentorDB _context;
        public AboutController(MentorDB context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            About about = _context.Abouts.Include(a => a.AboutImages).FirstOrDefault();
            if (about == null) return BadRequest();
            return View(about);
        }
    }
}
