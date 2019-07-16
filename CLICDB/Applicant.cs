using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class Applicant
    {
        public int ApplicationId { get; set; }
        public DateTime DateRequested { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Email { get; set; }
        public string AppAddress { get; set; }
        public string PostalCode { get; set; }       
        public string FormerClient { get; set; }
        public string LastVisit { get; set; }
        public int NoOfChildren { get; set; }
        public string CaseManager { get; set; }
        public string Agency { get; set; }
        public string RequestedItem { get; set; }
        public string RequestedNote { get; set; }
        public string CallStatus { get; set; }

        public Applicant()
        {
            ApplicationId = -1;
           // DateRequested = null;
            FirstName = "";
            LastName = "";
            Name = "";
            //DateOfBirth = null;
            PrimaryPhone = null;
            SecondaryPhone = null;
            Email = null;
            AppAddress = null;
            PostalCode = null;
            //FormerClient = null;
            NoOfChildren = -1;
            CaseManager = null;
            Agency = null;
            RequestedItem = "";
            RequestedNote = null;
            CallStatus = "";
        }

        public Applicant(int id, DateTime dr, string fn, string ln, DateTime? dob, string pp, string sp, string em,
                         string aa, string pc, string fc, string lv, int nc, string cm, string ag, string ri, string rn, string cs)
        {
            ApplicationId = id;
            DateRequested = dr;
            FirstName = fn;
            LastName = ln;
            DateOfBirth = dob;
            PrimaryPhone = pp;
            SecondaryPhone = sp;
            Email = em;
            AppAddress = aa;
            PostalCode = pc;
            FormerClient = fc;
            LastVisit = lv;
            NoOfChildren = nc;
            CaseManager = cm;
            Agency = ag;
            RequestedItem = ri;
            RequestedNote = rn;
            CallStatus = cs;
        }

        public Applicant(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
        public Applicant (int id)
        {
            ApplicationId = id;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
