using Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.User
{
    public class BusinessArea : BaseModel
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string Designation { get; set; }

        public bool? IsActive { get; set; }

        #region foreign Keys

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
