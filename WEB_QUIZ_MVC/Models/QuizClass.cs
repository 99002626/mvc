using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_QUIZ_MVC.Models
{
    public class QuizClass
    {
        public int QId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Correctans { get; set; }

    }
}