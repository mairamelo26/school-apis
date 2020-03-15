using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    public enum NotificationTemplatesEnum
    {
        SysDiagnosisModelPublished,
        NewOUProcess,
        NewProcess,
        ProcessDeadlineAlert,
        CreateNewDiagnosisAlert,
        DiagnosisDeleted,
        ProcessOUChanged
    }

    public class NotificationTokens
    {
        public static readonly string DiagnosisDesignation = "{{DiagnosisDesignation}}";
        public static readonly string LinkToProcess = "{{LinkToProcess}}";
        public static readonly string ProcessBeginDate = "{{ProcessBeginDate}}";
        public static readonly string ProcessDeadlineDate = "{{ProcessDeadlineDate}}";
        public static readonly string ProcessDeadlineSysParameter = "{{ProcessDeadlineSysParameter}}";
        public static readonly string DiagnosisDesignationWithLink = "{{DiagnosisDesignationWithLink}}";
        public static readonly string DiagnosisEndDate = "{{DiagnosisEndDate}}";
        public static readonly string OUDesignation = "{{OUDesignation}}";
        public static readonly string OriginalOU = "{{OriginalOU}}";
        public static readonly string ActualOU = "{{ActualOU}}";
    }
}
