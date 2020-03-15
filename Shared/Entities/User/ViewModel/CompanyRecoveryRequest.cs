using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class CompanyRecoveryRequest
    {
        public UserToken Token { get; set; }
        public User User { get; set; }
    }
}
