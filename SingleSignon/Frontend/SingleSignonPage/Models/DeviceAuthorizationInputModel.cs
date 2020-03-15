using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SingleSignonPage.Controllers.Consent;

namespace SingleSignonPage.Models
{
    public class DeviceAuthorizationInputModel : ConsentInputModel
    {
        public string UserCode { get; set; }
    }
}
