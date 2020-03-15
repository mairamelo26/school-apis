using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Utils.Enums;

namespace Utils.Extensions
{
    public class PermissionsHelper
    {

        public static int WhatsMyLevel(List<string> roles)
        {
            if (roles.Contains(ProfileCode.system_management.ToString()))
            {
                return (int)ProfileLevel.Level_1;
            }
            else if (roles.Contains(ProfileCode.external_auditor.ToString()) || roles.Contains(ProfileCode.administrative.ToString()))
            {
                return (int)ProfileLevel.Level_10;
            }
            else
            {
                return (int)ProfileLevel.Level_20;
            }
        }

        public static bool CheckUserHasProfile(string[] userRoles, string profileCode)
        {
            bool authorized = false;

            foreach (string role in userRoles)
            {
                if (role == profileCode)
                {
                    authorized = true;
                    break;
                }
            }

            return authorized;
        }

        public static bool CheckUserIsSysAdmin(string userRoles)
        {
            bool authorized = false;

            var roles = JsonConvert.DeserializeObject<string[]>(userRoles);

            if (roles.Count() > 0)
            {
                authorized = CheckUserHasProfile(roles, ProfileCode.system_management.ToString());
            }

            return authorized;
        }

        public static bool CheckUserIsUnitAuditor(string userRoles)
        {
            bool authorized = false;

            var roles = JsonConvert.DeserializeObject<string[]>(userRoles);

            if (roles.Count() > 0)
            {
                authorized = CheckUserHasProfile(roles, ProfileCode.ou_auditor.ToString());
            }

            return authorized;
        }

        public static bool CheckUserIsCompanyAdmin(string userRoles)
        {
            bool authorized = false;

            var roles = JsonConvert.DeserializeObject<string[]>(userRoles);

            if (roles.Count() > 0)
            {
                authorized = CheckUserHasProfile(roles, ProfileCode.company_management.ToString());
            }

            return authorized;
        }

        public static bool CheckUserIsAdministrative(string userRoles)
        {
            bool authorized = false;

            var roles = JsonConvert.DeserializeObject<string[]>(userRoles);

            if (roles.Count() > 0)
            {
                authorized = CheckUserHasProfile(roles, ProfileCode.administrative.ToString());
            }

            return authorized;
        }

        public static bool CheckUserIsCompanyAuditor(string userRoles)
        {
            bool authorized = false;

            var roles = JsonConvert.DeserializeObject<string[]>(userRoles);

            if (roles.Count() > 0)
            {
                authorized = CheckUserHasProfile(roles, ProfileCode.auditor.ToString());
            }

            return authorized;
        }
    }
}
