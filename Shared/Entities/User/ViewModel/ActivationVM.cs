using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class ActivationVM
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string Password { get; set; }
        
        public int RequestType { get; set; }
    
        public string AdicionalPayload { get; set; }
    }
}
