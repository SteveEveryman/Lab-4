using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;
using System.Web;
using Microsoft.AspNetCore.Html;



namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            DateTime current = DateTime.Now;
            DateTime end = new DateTime(current.Year, 12, 31);
            double daysLeft = Convert.ToInt32((end - current).TotalDays);

            ViewData["clock"] = current.ToString("hh:mm tt");
            ViewData["calendar"] = current.ToString("MMMMMMMM dd, yyyy");
            ViewData["weekDay"] = current.DayOfWeek;
            ViewData["greeting"] = getGreeting();
            ViewData["daysLeft"] = daysLeft;
            ViewData["year"] = current.Year;

            return View("Index");

        }

        public IActionResult Waffle()
        {

            //id = Int32.Parse(Url.Action().Split("/").Last());
            //List<HtmlString> waffleList = new List<HtmlString>();
            //for (int i = 0; i < id; i++)
            //{
            //    var generatedWaffle = WaffleEngine.Html(1, true, false);
            //    HtmlString waffle = new HtmlString(generatedWaffle);
            //    waffleList.Add(waffle);
            //}
            //for (int j = 0; j < waffleList.Count; j++)
            //{
            //    ViewData["waffle"] = (waffleList[j]);
            //}

            var waffle = WaffleEngine.Html(2, true, false);

            return View(new HtmlString(waffle));

            


        }

  

     
        
        public String getGreeting()
        {
        if(DateTime.Now.Hour < 12)
            {
                return "Good Morning";
            }
        if(DateTime.Now.Hour < 18)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }       
        }


    }
}