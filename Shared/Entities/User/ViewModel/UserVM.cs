using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.User.ViewModel
{
    public class UserVM
    {
        public User User { get; set; }

        public Company Company { get; set; }
    }
    
    public class UserPostVM
    {
        public User User { get; set; }

        public List<UserHasProfileVM> UserProfiles { get; set; }
    }

    public class UserHasProfileVM
    {
        public Profile Profile { get; set; }

        public bool HasProfile { get; set; }
    }

    public class ChangePasswordVM
    {
        public int UserId { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }

        public string RepeatedNewPassword { get; set; }
    }
}
