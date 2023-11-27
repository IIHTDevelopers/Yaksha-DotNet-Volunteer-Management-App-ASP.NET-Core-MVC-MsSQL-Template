using VolunteerManagementApp.DAL.Interface;
using VolunteerManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VolunteerManagementApp.DAL.Repository
{
    public class VolunteerManagementService : IVolunteerInterface
    {
        private IVolunteerRepository _repo;
        public VolunteerManagementService(IVolunteerRepository repo)
        {
            this._repo = repo;
        }

        public Volunteer AddVolunteer(Volunteer volunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Volunteer DeleteVolunteer(int volunteerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Volunteer GetVolunteerById(int volunteerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Volunteer UpdateVolunteer(Volunteer volunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}