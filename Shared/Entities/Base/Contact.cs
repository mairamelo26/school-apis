using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Base
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public int AppEmail { get; set; }
    }
}
