using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class Inventory
    {
        public int PCPickUpNo { get; set; }
        public string PCType { get; set; }
        public string Model { get; set; }
        public string OldOS { get; set; }
        public string OldCOA { get; set; }
        public DateTime DateBuilt { get; set; }
        public DateTime? MarCreated { get; set; }
        public string NewCOA { get; set; }
        public string PCStatus { get; set; }
        public string Details { get; set; }
        public string Recipient { get; set; }

        public Inventory()
        {
            PCPickUpNo = -1;
            PCType = "";
            Model = "";
            OldOS = "";
            OldCOA = "";
            NewCOA = "";
            PCStatus = "";
            Details = "";
            Recipient = "";
        }
    }
}
