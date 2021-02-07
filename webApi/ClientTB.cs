using Fim_Insura.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fim_Insura
{
   public class ClientTB : BaseTable
    {
        //public int CoverValue { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Cellphone { get; set; }
        public string Password { get; set; }
        //public int PolicyPeriod { get; set; }
    }
}
