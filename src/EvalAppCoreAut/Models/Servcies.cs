using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvalAppCoreAut.Models
{
    public class Services
    {
        public Service ServiceType { get; set; }
        public bool IsBillable { get; set; }
        public bool IsCountsForRequired { get; set; }
        public bool IsCountForOT { get; set; }
        public string ServiceSuffix { get; private set; }

        public Services(Service serviceType)
        {
            ServiceType = serviceType;
            IsBillable = false;
            IsCountsForRequired = false;
            IsCountForOT = false;
            SetSuffix();
        }
        protected void SetSuffix()
        {
            StringBuilder suffixString = new StringBuilder("(___)");
            //ServiceSuffix = "(___)";
            if (ServiceType == Service.Consult)
            {
                suffixString[1] = 'b';
                IsBillable = true;
            }

            if (ServiceType == Service.Consult || ServiceType == Service.EvalSupp || ServiceType == Service.LeaveOth || ServiceType == Service.MakeUp || ServiceType == Service.Mathernity
                || ServiceType == Service.Operate || ServiceType == Service.Sell || ServiceType == Service.Sick_Leave || ServiceType == Service.SickChild || ServiceType == Service.Unpaid
                || ServiceType == Service.Vacation)
            {
                suffixString[2] = 'r';
                IsCountsForRequired = true;
            }
            if (ServiceType == Service.Consult || ServiceType == Service.Operate || ServiceType == Service.Vacation)
            {
                suffixString[3] = 'o';
                IsCountForOT = true;
            }
            ServiceSuffix = suffixString.ToString();
        }
    }
}
