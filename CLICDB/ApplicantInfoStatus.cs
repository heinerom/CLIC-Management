using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class ApplicantInfoStatus
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
        public DateTime? Attempt1 { get; set; }
        public string Remarks1 { get; set; }      
        public DateTime? Attempt2 { get; set; }
        public string Remarks2 { get; set; }
        public DateTime? Attempt3 { get; set; }
        public string Remarks3 { get; set; }
        public DateTime? ScheduledPickUp { get; set; }
        public DateTime? DatePickedUp { get; set; }
        public string PickUpNo { get; set; }
        public string Comments { get; set; }
        

        public ApplicantInfoStatus()
        {
            ApplicationId = -1;
            FirstName = "";
            LastName = "";
            Name = "";
            DateOfBirth = null;
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
            Remarks1 = "";
            Remarks2 = "";
            Remarks3 = "";
            PickUpNo = "";
            Comments = "";
        }

        public ApplicantInfoStatus(int id, DateTime dr, string fn, string ln, DateTime dob, string pp, 
                        string sp, string em, string aa, string pc, string fc, string lv, int nc, string cm, 
                        string ag, string ri, string rn, string cs, DateTime a1, string r1, DateTime a2,
                        string r2, DateTime a3, string r3, DateTime spu, DateTime dpu, string pun, string aps)
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
            Attempt1 = a1;
            Remarks1 = r1;
            Attempt2 = a2;
            Remarks2 = r2;
            Attempt3 = a3;
            Remarks3 = r3;
            ScheduledPickUp = spu;
            DatePickedUp = dpu;
            PickUpNo = pun;
            Comments = aps;
        }
        public ApplicantInfoStatus(int id, DateTime spu, DateTime dr, string pp, string ri, string rn, string cs, string aps)
        {
            ApplicationId = id;
            DateRequested = dr;
            PrimaryPhone = pp;
            RequestedItem = ri;
            RequestedNote = rn;
            CallStatus = cs;
            ScheduledPickUp = spu;
            Comments = aps;
        }
    }
}
