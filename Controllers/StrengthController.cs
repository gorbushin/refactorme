using Microsoft.AspNetCore.Mvc;

namespace refactorme.Controllers
{
    public class StrengthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Models.StrengthData strengthData)
        {
            switch (strengthData.Gender.ToString().ToLower())
            {
                case "male":
                    ViewData["Result"] = strengthData.WeightLifted * Wilks.CalculateWilks(strengthData.BodyWeight, true);
                    break;
                case "female":
                    ViewData["Result"] = strengthData.WeightLifted * Wilks.CalculateWilks(strengthData.BodyWeight, false);
                    break;
                default:
                    ViewData["Result"] = "Wilks formula doesn't work for Aliens :-)";
                    break;
            }

            return View();
        }
    }
}