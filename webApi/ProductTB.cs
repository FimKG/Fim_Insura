using Fim_Insura.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fim_Insura.webApi
{
    public class ProductTB : BaseTable
    {
        public string CoverValue { get; set; }
        public string Period { get; set; }
        public string ProductName { get; set; }
        public string PremiumPrice { get; set; }

    }
}
