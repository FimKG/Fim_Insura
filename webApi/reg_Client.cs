﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Fim_Insura.webApi
{
    class reg_Client
    {    
        public void reg_Clients(string CoverValue, string fName, string lName, string Adress, string email, 
            int policyPeriod, string dateOfBirth, string cellphone)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("message" + ex.ToString());
            }
        }
    }


}
