using Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.User
{
    public class User : BaseModel
    {
        [Key]
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }

        public string ProfileImage { get; set; }

        public string Filename { get; set; }

        public string Password { get; set; }

        public bool IsVerified { get; set; }

        public bool IsActive { get; set; }

        public int? LoginAttempts { get; set; }

        #region ForeignKeys

        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public int? BusinessAreaId { get; set; }

        [ForeignKey("BusinessAreaId")]
        public virtual BusinessArea BusinessArea { get; set; }

        public virtual ICollection<UserProfile> UserProfiles { get; set; }

        #endregion

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        #endregion
    }
}
