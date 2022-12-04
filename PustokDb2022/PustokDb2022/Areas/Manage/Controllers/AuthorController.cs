using Microsoft.AspNetCore.Mvc;
using PustokDb2022.Areas.Manage.ViewModels;
using PustokDb2022.DAL;

namespace PustokDb2022.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AuthorController : Controller
    {
        private readonly PustokDbContext _context;

        public AuthorController(PustokDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardViewModel AuthorVM = new DashboardViewModel
            {
                Authors = _context.Authors.ToList()
            };
            return View(AuthorVM);
        }
    }
}
