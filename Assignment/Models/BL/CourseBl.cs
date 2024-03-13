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
    }
}
