using Fim_Insura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fim_Insura.webApi
{
    public class ClaimTB : BaseTable
    {
        public string ProductName { get; set; }
        public string PremiumPrice { get; set; }
    }
}
