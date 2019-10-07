using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    //    public string Hello() { return "Hello friend!"; }

    [Route("/")]
    public ActionResult Madlibber()
    {
        MadLibFields myMadLibFields = new MadLibFields();
        myMadLibFields.Word1_PastTenseVerb = "smurfed";
        myMadLibFields.Word2_Adjective = "spiky";
        myMadLibFields.Word3_Noun = "black bean";
        myMadLibFields.Word4_Verb = "bother";
        return View(myMadLibFields);
    }

  }
}