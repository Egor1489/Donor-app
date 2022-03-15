using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.AppDataFile
{
    class ProductObj
    {
        public static int ID_Edinica { get; set; }
        public static string GUID_Donor { get; set; }
        public static string Component { get; set; }
        public static int FK_Status { get; set; }
        public System.DateTime Date_Sbora { get; set; }
        public System.DateTime Date_Freeze { get; set; }
        public static string Group { get; set; }
        public static string Rh { get; set; }
    }
}
