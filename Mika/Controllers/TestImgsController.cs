using FakeItEasy.Sdk;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Mika.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mika.Models;

namespace Mika.Controllers
{
    public class TestImgsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TestImgsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TestImg testImgs)
        {

            return View();
        }

    }
}
