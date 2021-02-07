using Fim_Insura.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fim_Insura.webApi
{
    public class AdminTB: BaseTable
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Password { get; set; }
    }
}
