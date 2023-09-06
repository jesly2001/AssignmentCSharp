using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCSharp
{
    public class PrivateCollege:College
    {
        private int donation;
        private Address privateCollegeAddress;



        public Address PrivateCollegeAddress { get; set; }
        public int Donation { get; set; }



        public PrivateCollege(string collegeName, int donation, Address privateCollegeAddress)
        : base(collegeName)
        {
            PrivateCollegeAddress = privateCollegeAddress;
            Donation = donation;
        }



        public void CalculateFees(Student studentobj)
        {
            if (studentobj.Marks > 75 && Donation > 100000)
            {
                studentobj.CollegeFees = 75000 - (Donation * 0.5);
            }
            else
            {
                studentobj.CollegeFees = 75000;
            }
        }
    }
}
