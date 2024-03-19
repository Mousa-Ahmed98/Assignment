using Assignment.Models.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly ITIContext ITIContext;
        public InstructorRepository(ITIContext _ITIContext)
        {
            ITIContext = _ITIContext;
        }
        public List<Instructor> GetAll()
        {
            return ITIContext
                .Instructors
                .Include(I => I.Course)
                .Include(I => I.Department)
                .ToList();
        }

        public Instructor? Get(int Id)
        {
            return ITIContext
                .Instructors
                .Where(I => I.Id == Id)
                .Include(I => I.Course)
                .Include(I => I.Department).FirstOrDefault();
        }

        public async Task Add(Instructor instructor)
        {
            ITIContext.Instructors.Add(instructor);
            try
            {
                await ITIContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
