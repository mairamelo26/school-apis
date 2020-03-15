using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class JWTVM
    {
        public int? UserId { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Token { get; set; }
    }
}
