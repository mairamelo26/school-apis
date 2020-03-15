using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    public enum EmailTemplatesEnum
    {
        NewAccount,
        NewAccountCompany,
        NewAccountComercial,
        CompanyAccountRecovery,
        AccountActivation,
        AccountReactivation,
        AccountDeleted,
        PasswordRecovery,
        AccountRecovery,
        UsernameRecovery,
        UserReactivation,
        DisclaimerUpdated,
        ClientContact,
        PremiumSubscription,
        CompanyReactivation,
        CompanyContractExtension,
        CompanyToPremiumNotify,
        CompanyToPremiumComercialNotify,
        CompanyTrialEndContractNotify,
        CompanyPremiumEndContractNotify,
        CompanyContractExpiredNotify,
        NewDiagnosisSuggestNotify
    }

    public class EmailTokens
    {
        public static readonly string Company = "{{company}}";
        public static readonly string UserName = "{{username}}";
        public static readonly string Url = "{{url}}";
        public static readonly string Nif = "{{nif}}";
        public static readonly string Email = "{{email}}";
        public static readonly string ActiveUsers = "{{activeUsers}}";
        public static readonly string Disclaimer = "{{disclaimer}}";
        public static readonly string DisclaimerType = "{{disclaimertype}}";
        public static readonly string UserFullName = "{{Name}}";
        public static readonly string ClientSubject = "{{Subject}}";
        public static readonly string ClientMessage = "{{Message}}";
        public static readonly string ContractExpireDate = "{{contractExpireDate}}";
        public static readonly string Iban = "{{iban}}";
        public static readonly string Days = "{{days}}";
        public static readonly string Months = "{{months}}";
        public static readonly string Years = "{{years}}";
    }
}
