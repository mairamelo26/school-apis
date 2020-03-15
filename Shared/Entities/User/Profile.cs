using Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.User
{
    public class Profile: BaseModel
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string Designation { get; set; }

        public string Description { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public int Level { get; set; }

        #region MetaData

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsActive { get; set; }

        #endregion
    }
}
