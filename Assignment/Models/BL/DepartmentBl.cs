namespace Assignment.Models.BL
{
    public class DepartmentBl
    {
        static ITIContext ITIContext = new ITIContext();

        public static List<Department> GetAll()
        {
            return ITIContext.Departments.ToList();
        }
    }
}
