using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.EnrolledCourses = new List<StudentsInCourses>();
            this.LecturerCourses = new List<CourseInstance>();
            this.HomeworkSubmitions = new List<HomeworkSubmition>();
            this.Articles = new List<Article>();
        }

        public string FullName { get; set; }

        public ICollection<StudentsInCourses> EnrolledCourses { get; set; }

        public ICollection<CourseInstance> LecturerCourses { get; set; }

        public ICollection<HomeworkSubmition> HomeworkSubmitions { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
