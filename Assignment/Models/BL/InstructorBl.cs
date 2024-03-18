using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class InstructorBl
    {
        
        public static List<Instructor> GetAll()
        {
            return new ITIContext()
                .Instructors
                .Include(I => I.Course)
                .Include(I => I.Department)
                .ToList();
        }

        public static Instructor? Get(int Id)
        {
            return new ITIContext()
                .Instructors
                .Where(I => I.Id == Id)
                .Include(I => I.Course)
                .Include(I => I.Department).FirstOrDefault();
        }

        public static async Task Add(Instructor instructor)
        {
            new ITIContext().Instructors.Add(instructor);
            try
            {
                await new ITIContext().SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Instructor> Search(string Key)
        {
            if(Key != null)
            return new ITIContext()
                .Instructors
                .Where(i => i.Name.StartsWith(Key))
                .Include(i => i.Course)
                .Include(i => i.Department)
                .ToList();

            else
                return new ITIContext()
                .Instructors
                .Include(i => i.Course)
                .Include(i => i.Department)
                .ToList();
        }
    }
}
