using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    public enum ProfileCode
    {
        system_management,
        administrative,
        external_auditor,
        company_management,
        ou_auditor,
        auditor
    }

    public enum ProfileLevel
    {
        // System Administration
        Level_1 = 1,

        // System General User
        Level_10 = 10,

        // Company Users
        Level_20 = 20,
    }
    
}
