﻿using Kalakaar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalakaar.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any courses.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            //var students = new Student[]
            //{
            //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //};
            //foreach (Student s in students)
            //{
            //    context.Students.Add(s);
            //}
            //context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseCategory="PROFESSIONAL DESIGNING",Avail="In Stock", CourseName="Digital Textile Designing", Discription="Intro to course", Price=0, Instructor="Sami", Duration="8 Weeks", NoOfLectures= "16", StartDate=DateTime.Today, EndDate=DateTime.Today.AddMonths(3), Fees=0, Image1Url="img/shop101.jpg", ImgBanner="img/textilebg.jpg"}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();


            var users = new User[]
            {
            new User{Email="admin@kalakaar.com", Password="Sami-321"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();


            var Shops = new Shop[]
            {
            new Shop{}
            };
            foreach (Shop s in Shops)
            {
                context.Shops.Add(s);
            }
            context.SaveChanges();

            //var enrollments = new Enrollment[]
            //{
            //new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            //new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            //new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            //new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            //new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            //new Enrollment{StudentID=3,CourseID=1050},
            //new Enrollment{StudentID=4,CourseID=1050},
            //new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            //new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            //new Enrollment{StudentID=6,CourseID=1045},
            //new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            //};
            //foreach (Enrollment e in enrollments)
            //{
            //    context.Enrollments.Add(e);
            //}
            //context.SaveChanges();
        }
    }
}
