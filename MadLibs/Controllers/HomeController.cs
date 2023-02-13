using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController: Controller
  {
    [Route("/")]
    public ActionResult Splash() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() {return View();}

    [Route("/form3")]
    public ActionResult Form3() {return View();}

    [Route("/index")]
    public ActionResult Index() {return View();}

    [Route("/story")]
    public ActionResult Story(string noun1, string name1, string dayOfWeek, string number1)
    {
      MadVariable1 myMadVariable1 = new MadVariable1();
      myMadVariable1.Noun1 = noun1;
      myMadVariable1.Name1 = name1;
      myMadVariable1.DayOfWeek = dayOfWeek;
      myMadVariable1.Number1 = number1;
      return View(myMadVariable1);
    }
    
    [Route("/story2")]
    public ActionResult Story2(string name1, string noun1,  string place, string verb, string pastTenseVerb, string name2, string pluralAnimal1, string lengthOfTime)
    {
      MadVariable2 myMadVariable2 = new MadVariable2();
      myMadVariable2.Name1 = name1;
      myMadVariable2.Noun1 = noun1;
      myMadVariable2.Place = place;
      myMadVariable2.Verb = verb;
      myMadVariable2.PastTenseVerb = pastTenseVerb;
      myMadVariable2.Name2 = name2;
      myMadVariable2.PluralAnimal1 = pluralAnimal1;
      myMadVariable2.LengthOfTime = lengthOfTime;
      return View(myMadVariable2);
    }

    [Route("/story3")]
    public ActionResult Story3(string noun1, string presentParticiple1, string noun2, string userName)
    {
      MadVariable3 myMadVariable3 = new MadVariable3();
      myMadVariable3.Noun1 = noun1;
      myMadVariable3.PresentParticiple1 = presentParticiple1;
      myMadVariable3.Noun2 = noun2;
      myMadVariable3.UserName = userName;
      return View(myMadVariable3);
    }   
  }
}