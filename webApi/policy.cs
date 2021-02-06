using System;
using System.Collections.Generic;
using System.Text;

namespace Fim_Insura
{
    class policy
    {
        public int Id { get; set; }
        public int CoverValue { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string Cellphone { get; set; }
        public int PolicyPeriod { get; set; }
    }

    //public double CalculatePolicy(double coverValue, int policyperiod)
    //{
    //    //double premium;

    //    //premium = coverValue * policyperiod;
    //    //return premium;
    //    return coverValue * policyperiod;
    //}
}
