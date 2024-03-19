using Assignment.Models.BL;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Models.Services
{
    public interface IInstructorRepository
    {
        List<Instructor> GetAll();

        Task Add(Instructor instructor);

        Instructor? Get(int Id);
    }
}
