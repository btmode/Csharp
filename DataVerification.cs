using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCRUD {

    public interface ILOGGER
    {

    }
    public class DataRules
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string brithDate { get; set; }
       
    }
    class DataVerification
    {

    }
}