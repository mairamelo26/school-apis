using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    public enum ProcessType
    {
        RecomendationVerify = 1,
        ImproveVerify = 2
    }

    public enum ProcessStatus
    {
        Registered = 1,
        CompletedSuccess = 2,
        CompletedWithoutSuccess = 3
    }
}
