using Assignment.Models;
using Assignment.Models.BL;
using Assignment.Models.Services;
using Assignment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Controllers
{
    public class TraineeController : Controller
    {
        private readonly UnitOfWork unitOfWork = new UnitOfWork();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TraineeCourseResult(int TID, int CID)
        {
            TraineeCourseResultViewModel traineeCourseResultViewModel = 
                //= unitOfWork.CrsResRepository.Get()
                TraineeBL.GetTraineeCourseResult(TID, CID);
            if(traineeCourseResultViewModel == null)
            {
                return View("EmptyView");
            }
            return View("TraineeCourseResult", traineeCourseResultViewModel);
        }

        public IActionResult TraineeResult(int TID)
        {
            List<CrsResult> crsResults = TraineeBL.GetTraineeResult(TID);
            return View("TraineeResult", crsResults);
        }

        
    }
}
