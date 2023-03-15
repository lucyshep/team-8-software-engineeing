using TSE.Models;

namespace TSE.services
{
    public class AuthenticationRegister
    {
        //creates object of the Register class 
        Register Register = new Register();

        //defines the constructor 
        public AuthenticationRegister()
        {
        }

        //function valid returns the find user function 
        public bool RegisterValid(UserModel user)
        {
            
            return Register.AddUser(user);

        }
    }
}
