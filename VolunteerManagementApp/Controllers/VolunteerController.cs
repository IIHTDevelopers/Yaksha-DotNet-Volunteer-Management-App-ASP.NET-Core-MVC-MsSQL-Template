using Microsoft.AspNetCore.Mvc;
using VolunteerManagementApp.DAL.Interface;
using VolunteerManagementApp.Models;

namespace VolunteerManagementApp.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly IVolunteerInterface _volunteerRepository;

        public VolunteerController(IVolunteerInterface volunteerRepository)
        {
            _volunteerRepository = volunteerRepository;
        }

        // GET: /Volunteer/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Volunteer/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Volunteer/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Volunteer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Volunteer volunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Volunteer/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Volunteer/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Volunteer updatedVolunteer)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Volunteer/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Volunteer/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
