using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.Models;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly MyPortfolioContext _context;

        public ToDoListController(MyPortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ToDoLists.ToList();
            return View(values);
        }

        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList model)
        {
            model.Status = false;
            _context.ToDoLists.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var delitem = _context.ToDoLists.Find(id);
            if (delitem == null) return NotFound();
            _context.ToDoLists.Remove(delitem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateToDoList(int id)
        {
            var value = _context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList model, int id)
        {
            var value = _context.ToDoLists.Find(id);
            if (model == value) return NotFound();

            value.Title = model.Title;
            value.Date = model.Date;
            value.ImageUrl = model.ImageUrl;
            value.Status = model.Status;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoStatus(int id)
        {
            var item = _context.ToDoLists.Find(id);
            if (item == null) return NotFound();
            if (item.Status == false) item.Status=true;
            else item.Status=false;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}