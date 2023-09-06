using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public delegate void StudentDelegate(Student studentobj);
    public class GovtCollege:College
    {
        private Address govtCollegeAddress;



        public Address GovtCollegeAddress
        {
            get;
            set;
        }
        public GovtCollege(string collegeName, Address govtCollegeAddress) : base(collegeName)
        {
            GovtCollegeAddress = govtCollegeAddress;
        }



        public void CalculateFeesBasedOnMarks(Student studentobj)
        {
            if (studentobj.Marks > 80)
            {
                studentobj.CollegeFees = 20000;
            }
            else
            {
                studentobj.CollegeFees = 35000;
            }
        }



        public void CalculateFeesBasedOnSportsQuota(Student studentobj)
        {
            if (studentobj.SportsQuota)
            {
                studentobj.CollegeFees -= 5000;
            }
        }



        public void SetFees(Student studentobj)
        {
            StudentDelegate studentDelegate = CalculateFeesBasedOnMarks;
            studentDelegate += CalculateFeesBasedOnSportsQuota;



            studentDelegate(studentobj);
        }

    }
}
