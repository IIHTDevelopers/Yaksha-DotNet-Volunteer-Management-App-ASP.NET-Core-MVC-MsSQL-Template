using VolunteerManagementApp.DAL.Interface;
using VolunteerManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VolunteerManagementApp.DAL.Repository
{
    public class VolunteerRepository : IVolunteerRepository
    {
        private VolunteerDbContext _context;
        public VolunteerRepository(VolunteerDbContext Context)
        {
            this._context = Context;
        }
      
        public Volunteer GetVolunteerById(int volunteerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Volunteer AddVolunteer(Volunteer volunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Volunteer UpdateVolunteer(Volunteer updatedVolunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Volunteer DeleteVolunteer(int volunteerId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
