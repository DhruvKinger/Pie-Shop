using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EnterpriseApplication.Models;
using Microsoft.AspNetCore.Authorization;

namespace EnterpriseApplication.Controllers
{
    [Authorize]
    public class FeedBackController : Controller
    {
        private readonly IFeedBackRepositry _feedbackrepositry;

        public FeedBackController(IFeedBackRepositry feedbackrepositry)
        {
            _feedbackrepositry = feedbackrepositry;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                _feedbackrepositry.AddFeedBack(feedBack);
                return RedirectToAction("FeedBackComplete");
            }
            return View(feedBack);
            
            
        }


        public IActionResult FeedBackComplete()
        {
            return View();
        }
    }
}