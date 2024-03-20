namespace Assignment.Models.Services
{
    public class UnitOfWork
    {
        private readonly ITIContext context = new ITIContext();
        private GenericRepository<Instructor>? instructorRepository;
        private GenericRepository<Department>? departmentRepository;
        private GenericRepository<Trainee>? traineeRepository;
        private GenericRepository<Course>? courseRepository;
        private GenericRepository<CrsResult>? crsResRepository;

        public GenericRepository<Instructor> InstructorRepository
        {
            get
            {
                if(instructorRepository == null)
                {
                    return new GenericRepository<Instructor>(context);
                }
                return instructorRepository;
            }
        }

        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                if (departmentRepository == null)
                {
                    return new GenericRepository<Department>(context);
                }
                return departmentRepository;
            }
        }

        public GenericRepository<Trainee> TraineeRepository
        {
            get
            {
                if (traineeRepository == null)
                {
                    return new GenericRepository<Trainee>(context);
                }
                return traineeRepository;
            }
        }

        public GenericRepository<Course> CourseRepository
        {
            get
            {
                if (courseRepository == null)
                {
                    return new GenericRepository<Course>(context);
                }
                return courseRepository;
            }
        }

        public GenericRepository<CrsResult> CrsResRepository
        {
            get
            {
                if (crsResRepository == null)
                {
                    return new GenericRepository<CrsResult>(context);
                }
                return crsResRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }


    }
}
