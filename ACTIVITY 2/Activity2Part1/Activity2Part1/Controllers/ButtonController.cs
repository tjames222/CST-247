using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        public static List<ButtonModel> buttons = new List<ButtonModel>();

        // GET: Button
        public ActionResult Index()
        {
            buttons.Add(new ButtonModel(false));
            buttons.Add(new ButtonModel(false));

            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine == "1")
            {
                buttons.ElementAt(0).State = true;
                buttons.ElementAt(1).State = false;
            }
            else
            {
                buttons.ElementAt(0).State = false;
                buttons.ElementAt(1).State = true;
            }

            return View("Button", buttons);
        }
    }
}