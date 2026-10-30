using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.Logging;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class MessageController : Controller
    {
        private readonly MyPortfolioContext _context;

        public MessageController (MyPortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Inbox()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        // [HttpPost]
        public IActionResult ChangeIsRead(int id)
        {
            var msg = _context.Messages.Where(i=> i.MessageID == id).FirstOrDefault();

            if (msg == null)
            {
                return NotFound();
            }

            if (msg.IsRead == true)
            {
                msg.IsRead=false;
            }
            else
            {
                msg.IsRead=true;
            }
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage (int id)
        {
            var delItem = _context.Messages.Find(id);
            _context.Messages.Remove(delItem);
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }


        public IActionResult MessageDetail (int id)
        {
            var message = _context.Messages.Find(id);
            if (message == null)
            {
                return NotFound();
            }
            message.IsRead=true;
            _context.SaveChanges();

            return View(message);
        }
    }
}