using Microsoft.AspNetCore.Mvc;
using TSE.Models;
using TSE.services;

namespace TSE.Controllers
{
    public class AssignStaffController : Controller
    {
        public IActionResult AssignStaffForm()
        {
            //returns the view with the form 
            return View();
        }

        //when the submit button is pressed
        public IActionResult assign(AssignStaff assignStaff)
        {

            //creates new object of the auth assgin class 
            authAssign Auth = new authAssign();
            //if valid 
            if (Auth.valid(assignStaff))
            {

                //creates new veiw called assign success
                return View("AssignSuccess", assignStaff);
            }

            //else - not valid
            else
            {
                //creates new veiw called unsuccessfulAssign
                return View("unsuccessfullAssign", assignStaff);
            }

        }
    }
}

