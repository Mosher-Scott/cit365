using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        // Allows you to specify a primary key instead of having the system make one for you
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Nav property. A course can be related to multiple enrollments
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
