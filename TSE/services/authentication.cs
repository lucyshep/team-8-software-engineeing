using TSE.Models;
namespace TSE.services
{
    public class authentication
    {
        
        //creates object of the users dao class 
        Usersdao Usersdao = new Usersdao();

        //defines the constructor 
        public authentication()
        {
        }

        //function valid returns the find user function 
        public bool valid (UserModel user)
        {
            return Usersdao.findUser(user);
           
        }
    }
}
