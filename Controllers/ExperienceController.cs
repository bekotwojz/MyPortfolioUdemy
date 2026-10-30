using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.Models;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly MyPortfolioContext _context;
        public ExperienceController (MyPortfolioContext context)
        {
            _context = context;   
        }
        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience model)
        {
            _context.Experiences.Add(model);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }




        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var updItem = _context.Experiences.Find(id);
            if (updItem == null)
            {
                return NotFound();
            }

            return View(updItem);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience model)
        {
            var editItem = _context.Experiences.Find(model.ExperienceID);
            if (editItem == null)
            {
                return NotFound();
            }

            editItem.Description = model.Description;
            editItem.Date = model.Date;
            editItem.Head = model.Head;
            editItem.Title = model.Title;
            _context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }


        public IActionResult DeleteExperience(int id)
        {
            var delItem = _context.Experiences.Find(id);
            if (delItem != null)
            {
                _context.Remove(delItem);
                _context.SaveChanges();
            }

            return RedirectToAction("ExperienceList");
        }
    }
}