﻿using University.BL.Models;

namespace University.BL.Repositories.Implements
{
    public class OfficeAssignmentRepository : GenericRepository<OfficeAssignment>, IOfficeAssignmentRepository
    {
        public OfficeAssignmentRepository(UniversityModel universityModel) : base(universityModel)
        {

        }
    }
}
