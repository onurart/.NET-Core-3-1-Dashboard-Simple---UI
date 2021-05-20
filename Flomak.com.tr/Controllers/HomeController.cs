using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flomak.com.tr.Models;
using System.Security.Claims;
using Flomak.com.tr.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Flomak.com.tr.Controllers
{
    public class HomeController : Controller
    {
        Context _context;
        Flomak.com.tr.ViewModels.HomeViewModel _abount;
        private readonly ILogger<HomeController> _logger;

        public HomeController(Context context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel vmm = new HomeViewModel();
            var abouts = await _context.News.OrderByDescending(x => x.ID).Take(3).ToListAsync();
            var missons = await _context.Missions.FirstOrDefaultAsync();
            var service = await _context.Services.ToListAsync();
            var Sectors = await _context.Sectors.ToListAsync();
            var FlomakSectors = await _context.FlomakSectors.ToListAsync();
            var References = await _context.References.ToListAsync();
            var Sliders = await _context.Sliders.ToListAsync();


            vmm.News = abouts;
            vmm.Missions = missons;
            vmm.Services = service;
            vmm.Sectors = Sectors;
            vmm.FlomakSectors = FlomakSectors;
            vmm.References = References;
            vmm.Sliders = Sliders;

            //var name = User.Claims.Where(c => c.Type == ClaimTypes.Name)
            // .Select(c => c.Value).SingleOrDefault();
            return View(vmm);
        }

        public async Task<IActionResult> About()
        {
            HomeViewModel vm = new HomeViewModel();
            var abouts = await _context.News.OrderByDescending(x => x.ID).Take(3).ToListAsync();
            var missons = await _context.Missions.FirstOrDefaultAsync();
            var service = await _context.Services.ToListAsync();

            vm.News = abouts;
            vm.Missions = missons;
            vm.Services = service;


            //var name = User.Claims.Where(c => c.Type == ClaimTypes.Name)
            // .Select(c => c.Value).SingleOrDefault();
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
