using ApostaGenerator.Data;
using ApostaGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApostaGenerator.Controllers
{
    public class ApostaController : Controller
    {
        private readonly DataContext _context;

        public ApostaController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var apostas = _context.Apostas.ToList();
            return View(apostas);
        }

        public IActionResult Create()
        {
            var aposta = new Aposta();
            _context.Apostas.Add(aposta);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
