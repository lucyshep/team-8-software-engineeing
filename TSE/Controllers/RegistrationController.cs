using Microsoft.AspNetCore.Mvc;
using TSE.Models;
using TSE.services;

namespace TSE.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult DisplaySignUp()
        {
            return View();
        }
        //creates action for when submit button pressed 
        public IActionResult ProcessSubmit(UserModel usermodel)
        {
            
            //creates new object of the authenication class 
            AuthenticationRegister reg = new AuthenticationRegister();
            //if valid 
            if (reg.RegisterValid(usermodel))
            {
                //creates new veiw called successfulLogin
                return View("successfulRegistration", usermodel);
            }

            //else - not valid
            else
            {
                //creates new veiw called unsuccessfulLogin
                return View("unsuccessfulRegistration", usermodel);
            }

        }
    }
}
