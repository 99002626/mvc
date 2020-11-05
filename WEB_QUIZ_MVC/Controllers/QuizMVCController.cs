using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_QUIZ_MVC.Models;
using System.Net.Http;
namespace WEB_QUIZ_MVC.Controllers
{
    public class QuizMVCController : Controller
    {
        // GET: QuizMVC
        public ActionResult login()
        {
            ViewBag.Title = "login Page";

            return View();
        }
        public ActionResult registration()
        {
            ViewBag.Title = "registration Page";

            return View();
        }
        public ActionResult Index()
        {
            IEnumerable<QuizClass> qc = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("http://localhost:58698/api/Quiz");
            var consumeapi = hc.GetAsync("Quiz");
            consumeapi.Wait();
            var readdata = consumeapi.Result;
            if(readdata.IsSuccessStatusCode)
            {
                var displaydata = readdata.Content.ReadAsAsync<IList<QuizClass>>();
                displaydata.Wait();
                qc = displaydata.Result;
            }
            return View(qc);
        }
    }
}