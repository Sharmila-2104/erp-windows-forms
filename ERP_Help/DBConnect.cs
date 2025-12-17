using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Help
{
    public class DBConnect
    {
        public String Connection()
        {
            string constring = "";
            constring = "Server=DESKTOP-ROFKU18\\SQLEXPRESS;Initial Catalog=MRS_ERP; User ID=Admin; Password=Admin@123";

           // constring = "Server=38.242.195.255;Initial Catalog=MRS_ERP; User ID=adouterp; Password=7~wdqRy9J17mGvbb";
            //constring = "Server=MRSOFT;Initial Catalog=MRS_ERP; User ID=sa; Password=Mind@123";
            return constring;
        }
    }
}
