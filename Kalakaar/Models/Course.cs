using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalakaar.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseCategory { get; set; }
        public string CourseName { get; set; }
        public int Price { get; set; }
        public string Avail { get; set; }
        public string Discription { get; set; }
        public string Image1Url { get; set; }
        public string Image2Url { get; set; }
        public string ImgBanner { get; set; }
        public string Instructor { get; set; }
        public string NoOfLectures { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Fees { get; set; }
        public string Duration { get; set; }

    }
}
