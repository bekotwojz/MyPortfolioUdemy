using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers;

public class LayoutController : Controller
{
    private readonly MyPortfolioContext _context;
    public LayoutController (MyPortfolioContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
}