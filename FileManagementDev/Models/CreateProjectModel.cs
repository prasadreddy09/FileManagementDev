using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileManagementDev.Models
{
    public class CreateProjectModel
    {
        public string ProjectName { get; set; }

        public List<ProjectTypes> ProjectType { get; set; }

        public List<Works> ScopeOfWork { get; set; }

        public string Notes { get; set; }

        public string JobNumber { get; set; }

        public List<string> JobSheetUrl { get; set; }

        public List<string> ContractDrawingUrl { get; set; }

        public string PurchaseOrder { get; set; }

        public BarCodeInformations BarCodeInformation { get; set; }
    }
}