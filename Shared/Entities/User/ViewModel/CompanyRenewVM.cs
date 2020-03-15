using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class CompanyRenewVM
    {
        public int CompanyId { get; set;}
        public int CompanyType { get; set;}
        public DateTime ContractExpireDate { get; set;}
        public bool Reactivation { get; set; }
    }
}
