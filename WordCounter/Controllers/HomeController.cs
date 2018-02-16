using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("hasResult", false);
      return View("Index", model);
    }
    
    [HttpPost("/")]
    public ActionResult Show()
    {
      RepeatCounter counter = new RepeatCounter(Request.Form["text"]);
      Dictionary<string, object> model = new Dictionary<string, object>();
      string search = Request.Form["search"];
      model.Add("search", search);
      model.Add("showAll", Request.Form["option"] == "all");
      model.Add("wordCounter", counter);
      model.Add("hasResult", counter.GetIsValid());
      return View("Index", model);
    }
  }
}
