using Assignment.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models.BL
{
    public class CourseBl
    {
        static ITIContext ITIContext = new ITIContext();

        public static Course GetCourseResult(int CID)
        {
            Course Course = ITIContext
                .Courses
                .Where(c => c.Id == CID)
                .Include(c => c.crsResults)
                .ThenInclude(CRR => CRR.Trainee)
                .Single();

            return Course;
        }


        public static List<Course> GetAll()
        {
            return ITIContext.Courses.ToList();
        }

        public static async Task<int> Add(Course course)
        {
            try
            {
                ITIContext.Courses.Add(course);
                await ITIContext.SaveChangesAsync();
                return 1;
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        internal static bool IsValidToAdd(AddCourseVM addCourseVM)
        {
            return (
                addCourseVM.Name != null 
                && addCourseVM.Name.Length > 0
                && addCourseVM.Hours > 0
                && addCourseVM.MinDegree > 0) ? true : false;
        }

        public static Course? GetCourse(int CID)
        {
            return ITIContext
                    .Courses
                    .FirstOrDefault(c => c.Id == CID);
        }
    }
}
