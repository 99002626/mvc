using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_QUIZ_MVC.Models;
namespace WEB_QUIZ_MVC.Controllers
{
    public class QuizController : ApiController
    {
        [HttpGet]
        public IHttpActionResult onlinequiz()
        {

            quiz_tableEntities qt = new quiz_tableEntities();
            IList<QuizClass> q = qt.onlinequizs.Include("onlinequiz").Select(x => new QuizClass()
            {
                QId = x.QId,
                Question = x.Question,
                Option1 = x.Option1,
                Option2 = x.Option2,
                Option3 = x.Option3,
                Option4 = x.Option4,
                Correctans = x.Correctans
            }).ToList<QuizClass>();
            return Ok(q);
        }
    }
}
