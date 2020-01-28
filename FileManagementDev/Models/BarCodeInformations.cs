using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileManagementDev.Models
{
    public class BarCodeInformations
    {
        public int StockLength { get; set; }

        public string BarGrade { get; set; }

        public string StandardSplice { get; set; }

        public string MechanicalSplice { get; set; }
    }
}