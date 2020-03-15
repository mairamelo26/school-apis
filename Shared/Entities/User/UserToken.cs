using Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.User
{
    public enum TokenType
    {
        Signup = 1,
        Password_Set = 2,
        Password_Reset = 3,
        Account_Reset = 4,
        Account_Recovery = 5
    }

    public class UserToken : BaseModel
    {
        [Key]
        public int? Id { get; set; }
        

        public int TokenType { get; set; }

        public string Token { get; set; }

        public DateTime ExpireDate { get; set; }

        public bool IsUsed { get; set; }

        #region ForeignKeys

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        #endregion

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        #endregion
    }
}
