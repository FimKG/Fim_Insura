using System;
using System.Collections.Generic;
using System.Text;

namespace Fim_Insura.Models
{
    public class UserModel:BaseTable
    {
        int clientID { get; set; }
        String FName { get; set; }
        String lastNmae { get; set; }
        String Address { get; set; }
        String email { get; set; }
        String dob { get; set; }
        String policyPeriod { get; set; }
        String cellphone { get; set; }
        String password { get; set; }
    }
}
