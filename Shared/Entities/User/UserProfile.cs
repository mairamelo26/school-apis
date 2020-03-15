using Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.User
{
    public class UserProfile : BaseModel
    {
        [Key]
        public int? Id { get; set; }

        #region ForeignKeys
        
        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProfileId { get; set; }
        
        [ForeignKey("ProfileId")]
        public virtual Profile Profile { get; set; }

        #endregion

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }
}
