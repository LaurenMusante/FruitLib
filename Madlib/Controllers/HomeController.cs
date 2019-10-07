using Microsoft.AspNetCore.Mvc;
using Madlib.Models;

namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/Madlibber")]
    public ActionResult Madlibber(string word1, string word2, string word3, string word4 )
    {
        MadLibFields myMadLibFields = new MadLibFields();
        myMadLibFields.Word1 = word1;
        myMadLibFields.Word2 = word2;
        myMadLibFields.Word3 = word3;
        myMadLibFields.Word4 = word4;
        return View(myMadLibFields);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

  }
}