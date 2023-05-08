using TSE.Models;

namespace TSE.services
{
    public class authAssign
    {
        //creates an object of the assign staff service class 
        AssignStaffService AssignStaffService = new AssignStaffService();

        //defines the constructor 
        public authAssign()
        {
        }

        //function valid returns the find user function 
        public bool valid(AssignStaff staff)
        {
            return AssignStaffService.findStaffMember(staff);

        }
    }
}

