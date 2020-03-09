using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // This will be the table primary key
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigational property.  This holds other entities related to this one.  If a student has enrolled in 1 or more classes, this property will contain those enrollments
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
