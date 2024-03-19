using Assignment.Models.Services;

namespace Assignment.Models.BL
{
    public class DepartmentRepository : IDepartmentRepository
    {
        ITIContext ITIContext;

        public DepartmentRepository(ITIContext iTIContext)
        {
            ITIContext = iTIContext;
        }
        public List<Department> GetAll()
        {
            return ITIContext.Departments.ToList();
        }
    }
}
