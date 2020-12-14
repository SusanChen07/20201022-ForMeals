using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_LocalDB1009
{
    class Globalval
    {
        public static int logauth;
        public static int logid;
        public static int classID;
        public static string 班級;
        public static string 帳號;
        public static string 密碼;
        public static string myDBConStr = @"Data Source=.;Initial Catalog=mealdb;Integrated Security=True";
    }
}
