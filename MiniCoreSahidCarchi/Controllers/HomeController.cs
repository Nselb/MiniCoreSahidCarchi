using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniCoreSahidCarchi.Data;
using MiniCoreSahidCarchi.Models;
using System.Diagnostics;

namespace MiniCoreSahidCarchi.Controllers
{
    public class HomeController : Controller
    {
        private readonly MiniCoreSahidCarchiContext _context;
        public HomeController(MiniCoreSahidCarchiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var totales = _context.vw_Contratos.ToList();
            return View(totales);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}