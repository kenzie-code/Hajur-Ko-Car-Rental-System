using HamroCarRental.Repository.IRepository;
using HamroCarRental.Repository.Models;
using HamroCarRental.Repository.Repository;
using RootLibrary.ViewModels;

namespace HamroCarRental.API.BusinessLogic
{
    public class AddStaffBL
    {
        private readonly IAddStaffRepo _addStaffRepo;
        
        public AddStaffBL(IAddStaffRepo addStaffRepo)
        {
            _addStaffRepo = addStaffRepo;
        }

        
        public async Task<bool> AddNewStaff(StaffVM data)
        {
            var staff = new Staff
            {
                Name = data.Name,
                Email = data.Email,
                Address = data.Address,
                Password = data.Password,
                Position = data.Position,
            };
            
            var result = await _addStaffRepo.AddStaff(staff);

            return result;
        }
    }
}
