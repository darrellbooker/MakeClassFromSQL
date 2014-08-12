using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeClassFromSQL
{
    public class Table
    {
        public System.String VinNo { get; set; }
        public System.String CustomerNo { get; set; }
        public System.Int32 RequestID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public System.String Location { get; set; }
        public System.String Company { get; set; }
        public System.String Holder { get; set; }
        public System.String Vehicle { get; set; }
        public System.String SiteName { get; set; }
        public System.Decimal InsFee { get; set; }
        public System.String Status { get; set; }
        public System.Int32 StatusSort { get; set; }
        public System.String ReportIn { get; set; }
        public System.DateTime PicsReceivedDateTime { get; set; }
    }
}
