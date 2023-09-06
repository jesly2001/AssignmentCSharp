using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class College
    {
        static int counter = 1001;



        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public College(string collegeName)
        {
            CollegeId = counter++;
            CollegeName = collegeName;



        } 
    }
}
