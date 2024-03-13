using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Assignment.Models.BL
{
    public class TraineeBL
    {
        static ITIContext ITIContext = new ITIContext();
        public static TraineeCourseResultViewModel GetTraineeCourseResult(int TID, int CID)
        {
            CrsResult? crsResult = ITIContext
            .CrsResults
                .Where(cr => cr.CourseId == CID && cr.TraineeId == TID)
                .Include(cr => cr.Course)
                .Include(cr => cr.Trainee)
                .FirstOrDefault();

            TraineeCourseResultViewModel StdCrsResVM = new TraineeCourseResultViewModel();
            if(crsResult == null)
            {
                return null;
            }
            StdCrsResVM.TraineeName = crsResult.Trainee.Name;
            StdCrsResVM.CourseName = crsResult.Course.Name;
            StdCrsResVM.Grade = crsResult.Degree;
            StdCrsResVM.Color = crsResult.Degree >= crsResult.Course.MinDegree ? "Green" : "Red";
            return StdCrsResVM;
        }

        public static List<CrsResult> GetTraineeResult(int TID)
        {
            List<CrsResult> crsResults = ITIContext
                .CrsResults
                .Include(cr => cr.Trainee)
                .Include(cr => cr.Course)
                .Where(cr => cr.TraineeId == TID)
                .ToList();
            

            return crsResults;
        }
    }
}
