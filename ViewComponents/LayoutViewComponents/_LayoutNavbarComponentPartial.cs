using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _LayoutNavbarComponentPartial (MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.ToDoLists.Where(x=> x.Status == false).ToList();
            ViewBag.toDoListCount = values.Count();
            return View(values);
        }
    }
}