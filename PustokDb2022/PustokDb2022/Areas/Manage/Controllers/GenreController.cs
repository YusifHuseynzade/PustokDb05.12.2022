using Microsoft.AspNetCore.Mvc;
using PustokDb2022.Areas.Manage.ViewModels;
using PustokDb2022.DAL;

namespace PustokDb2022.Areas.Manage.Controllers
{
    [Area("manage")]
    public class GenreController : Controller
    {
        private readonly PustokDbContext _context;

        public GenreController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardViewModel GenreVM = new DashboardViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(GenreVM);
        }
    }
}
