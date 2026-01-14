using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Catalogue_App
{
    public class UserCheck
    {
        public static bool IsStaff = false;                                 //public field bool so other classes can access
        public static List<string> loginhistory = new List<string>();       //public field list so other classes can access
    }
}
