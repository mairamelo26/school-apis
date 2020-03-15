using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class RegistrationVM
    {
        public User User { get; set; }

        public string CompanyName { get; set; }
        public string CompanyTin { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
    }
}
