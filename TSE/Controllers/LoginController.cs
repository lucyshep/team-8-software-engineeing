 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TSE.Models;
using TSE.services;

namespace TSE.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //creates action for when submit button pressed 
        public IActionResult ProccessLogin(UserModel usermodel)
        {
            //creates new object of the authenication class 
            authentication auth = new authentication();
            //if valid 
            if (auth.valid(usermodel))
            {
                //creates new veiw called successfulLogin
                return Redirect("~/Overview/Farm_Overview");
                //return View("successfulLogin", usermodel);
            }

            //else - not valid
            else
            {
                //creates new veiw called unsuccessfulLogin
                return View("unsuccessfulLogin", usermodel);
            }
           
        }
    }
}
